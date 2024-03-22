using System;
using System.Collections.Generic;
using CoreHelper;

namespace Core
{
    public interface IRuleEngineSessionFactory
    {
        IRuleEngineSession GetRuleEngineSession(ExecutionMode executionMode, IDictionary<string, IRuleInfo> ruleInfos, IWorkingMemory workingMemory, CoreHelper.IExternalDecisionProvider externalDecisionProvider, IRuleCompositionHelper ruleCompotionHelper, IExitStrategyInputData exitStrategyInputData);
    }

    public class RuleEngineSessionFactory:IRuleEngineSessionFactory
    {
        //public IRuleEngineSession GetRuleEngineSession(ExecutionMode executionMode, IWorkingMemory workingMemory, CoreHelper.IExternalDecisionProvider externalDecisionProvider, IRuleCompositionHelper ruleCompositionHelper)
        //{
        //    return GetRuleEngineSession(executionMode, DefaultRulesPath, workingMemory, externalDecisionProvider, ruleCompositionHelper);
        //}

        //public IRuleEngineSession GetRuleEngineSession(ExecutionMode executionMode, string ruleAssemblyPath, IWorkingMemory workingMemory, CoreHelper.IExternalDecisionProvider externalDecisionProvider, IRuleCompositionHelper ruleCompositionHelper)
        //{
        //    ValidateWorkingMemory(workingMemory);

        //    ReteGraphBuilder graphBuilder = new ReteGraphBuilder();
        //    var graph = graphBuilder.GetReteGraph(ruleAssemblyPath, ruleCompositionHelper, workingMemory.RootObject);

        //    return GetSession(graph, workingMemory, executionMode, externalDecisionProvider);

        //}

        public IRuleEngineSession GetRuleEngineSession(ExecutionMode executionMode, IDictionary<string, IRuleInfo> ruleInfos,
            IWorkingMemory workingMemory, CoreHelper.IExternalDecisionProvider externalDecisionProvider, IRuleCompositionHelper ruleCompositionHelper,IExitStrategyInputData exitStrategyInputData )
        {
            ValidateWorkingMemory(workingMemory);

            ReteGraphBuilder graphBuilder = new ReteGraphBuilder();
            var graph = graphBuilder.GetReteGraph(ruleInfos, ruleCompositionHelper, workingMemory.RootObject);

            return GetSession(graph, workingMemory, executionMode, externalDecisionProvider, exitStrategyInputData);
        }

        private IRuleEngineSession GetSession(IReteGraph graph, IWorkingMemory workingMemory, ExecutionMode executionMode, CoreHelper.IExternalDecisionProvider externalDecisionProvider, IExitStrategyInputData exitStrategyInputData)
        {
            IWorkingMemoryManager workingMemoryManager = new WorkingMemoryManager(workingMemory);

            IExitStrategyFactory exitStrategyFactory = new ExitStrategyFactory();

            IExitStrategyExecutor exitStrategyExecutor = new ExitStrategyExecutor(exitStrategyFactory.GetExitStrategy(exitStrategyInputData));

            IConflictResolution conflictResolution = ConflictResolutionFactory.GetConflictResolution(ConflictResolutionStrategy.Breadth);

            IExecutionContextInternal executionContext = new ExecutionContext(workingMemory.RootObject, executionMode, externalDecisionProvider);

            IExecutionEngine executionEngine = new ExecutionEngine(graph, exitStrategyExecutor, conflictResolution, executionContext);

            var session = new RuleEngineSession(executionMode, workingMemoryManager, executionEngine);

            return session;
        }

        private void ValidateWorkingMemory(IWorkingMemory workingMemory)
        {
            if (workingMemory == null)
            {
                throw new Exception("Rule Engine session cannot be created as Working memory is null");
            }

            if (workingMemory.RootObject == null || workingMemory.RootObject.FactCollection.Count == 0)
            {
                throw new Exception("Rule Engine session cannot be created as Root Object is not set correctly");
            }
        }

        private const string DefaultRulesPath = @"C:\Pms\system\Rules.dll";
    }
}