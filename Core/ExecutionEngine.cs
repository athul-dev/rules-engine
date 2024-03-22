using System;
using System.Collections.Generic;
using System.Linq;
using CoreHelper;
using Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces;

namespace Core
{
    internal interface IExecutionEngine
    {
        bool FireAllRules();

        void Halt();

        void ResetValues();

        int GetLastRulesExecutedCount();

        void LoadResult(Guid resultId);

    }

    internal class ExecutionEngine: IExecutionEngine
    {
        private IList<Guid> loadedResult = new List<Guid>();

        private IReteGraph graph;

        private IExecutionContextInternal currentExecutionContext;

        private readonly IConflictResolution conflictResolution;

        private readonly IExitStrategyExecutor exitStrategyExecutor;

        private bool forceHalt;

        private int lastRulesCount;
        

        public ExecutionEngine(IReteGraph graph, IExitStrategyExecutor exitStrategyExecutor, IConflictResolution conflictResolution,IExecutionContextInternal executionContext) 
        {
            this.graph = graph;
            this.exitStrategyExecutor = exitStrategyExecutor;
            this.conflictResolution = conflictResolution;
            currentExecutionContext = executionContext;
            SubscribeToActivate();
            var isSuccessful = Initialize();

            Contract.Ensures<Exception>(isSuccessful, "Execution Engine cannot be created");
        }

        public void LoadResult(Guid resultId)
        {
            if (loadedResult.Contains(resultId))
            {
                return;
            }

            loadedResult.Add(resultId);

            var isSuccess = false;

            var collection = currentExecutionContext.RootObject.Step.Children.First(x => x.Id == resultId).FactCollection;

            foreach (var kvp in collection)
            {
                if (kvp.Value == null)
                {
                    continue;
                }

                IToken token = new Token(new WorkingMemoryItem<IFact>(kvp.Value),resultId);

                graph.HeadNode.ProcessToken(token);
            }

            var internalRootObject = currentExecutionContext.RootObject as IRootObjectInternal;
            internalRootObject?.ExamRecordUpdater.UpdateCurrentEditedStepAndResult(currentExecutionContext.RootObject.CurrentStepId, resultId);

            HandleActivatedRules();

            isSuccess = CheckForExecutionSuccess();

            Contract.Ensures<Exception>(isSuccess, $"Result: with Result Id: {resultId}, cannot be loaded into Execution Engine");
        }

        public bool FireAllRules()
        {
            HandleActivatedRules();
            return CheckForExecutionSuccess();
        }

        public void Halt()
        {
            forceHalt = true;
        }

        private void HandleActivatedRules()
        {
            int ruleIndex = 0;
           
            do
            {
                var node = conflictResolution.GetRuleNode();
                if (node == null)
                {
                    exitStrategyExecutor.ResetOnSuccessfulExecution();
                    break;
                }

                exitStrategyExecutor.ProcessData(nameof(node));

                try
                {
                    node.Execute(currentExecutionContext); 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    break;
                }

                if (forceHalt)
                {
                    forceHalt = false;
                    break;
                }
                ruleIndex++;
            } while (!exitStrategyExecutor.HaltExecution);

            lastRulesCount = ruleIndex;
        }

        private bool CheckForExecutionSuccess()
        {
            if (conflictResolution.HasRules())
            {
                RevertToPreviousState();
                return false;
            }

            return true;
        }

        private void RevertToPreviousState()
        {
            var collection = currentExecutionContext.RootObject.FactCollection;
            foreach (var fact in collection)
            {
                fact.Value?.Revert();
            }
        }

        public void ResetValues()
        {
            var collection = currentExecutionContext.RootObject.FactCollection;
            foreach (var fact in collection)
            {
                fact.Value?.Reset();
            }
        }

        public int GetLastRulesExecutedCount()
        {
            return lastRulesCount;
        }

        private bool Initialize()
        {
            currentExecutionContext.Initialize(Halt);
            var stepCollection = currentExecutionContext.RootObject.Step.FactCollection;

            foreach (var kvp in stepCollection)
            {
                if (kvp.Value == null)
                {
                    continue;
                }

                IToken token = new Token(new WorkingMemoryItem<IFact>(kvp.Value), currentExecutionContext.RootObject.Step.Id);

                graph.HeadNode.ProcessToken(token);
            }

            var isSuccess = false;

            var collection = currentExecutionContext.RootObject.Step.Children.FirstOrDefault(x => x.Id == currentExecutionContext.RootObject.CurrentResultId)?.FactCollection;

            if (collection != null)
            {
                foreach (var kvp in collection)
                {
                    if (kvp.Value == null)
                    {
                        continue;
                    }

                    IToken token = new Token(new WorkingMemoryItem<IFact>(kvp.Value), currentExecutionContext.RootObject.CurrentResultId);

                    graph.HeadNode.ProcessToken(token);
                }
            }
            

            var internalRootObject = currentExecutionContext.RootObject as IRootObjectInternal;
            internalRootObject?.ExamRecordUpdater.UpdateCurrentEditedStepAndResult(currentExecutionContext.RootObject.CurrentStepId, currentExecutionContext.RootObject.CurrentResultId);

            HandleActivatedRules();

            isSuccess = CheckForExecutionSuccess();

            
            return isSuccess;

        }

        private void SubscribeToActivate()
        {
            foreach (var graphRuleNodeInfo in graph.RuleNodeInfos)
            {
                graphRuleNodeInfo.Value.RuleNode.Activated += RuleNode_Activated;
            }
        }

        private void RuleNode_Activated(object sender, EventArgs e)
        {
            var ruleNode = sender as IRuleNode;

            if (ruleNode == null) return;

            var priority = graph.RuleNodeInfos[ruleNode.ToString()].RulePriority;

            conflictResolution.AddRuleNode(priority, ruleNode);
        }
    }
}