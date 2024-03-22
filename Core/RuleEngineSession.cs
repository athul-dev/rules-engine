using System;
using System.Collections.Generic;
using CoreHelper;

namespace Core
{
    public interface IRuleEngineSession
    {
        bool UpdateParameter<T>(string parameterName, T value);

        bool UpdateCurrentEditedResult(Guid resultId);

        bool UpdateExecutionMode(ExecutionMode executionMode);

        IEnumerable<IChangeItem> GetChangeList();

        int GetPreviousRulesExecutedCount();

        Guid GetStepId();

        IList<Guid> GetResultIds();
    }

    internal class RuleEngineSession : IRuleEngineSession
    {
        private ExecutionMode executionMode;
        private readonly IWorkingMemoryManager workingMemoryManager;
        private readonly IExecutionEngine executionEngine;

        internal RuleEngineSession(ExecutionMode executionMode, IWorkingMemoryManager memoryManager, IExecutionEngine executionEngine)
        {
            this.executionMode = executionMode;
            this.workingMemoryManager = memoryManager;
            this.executionEngine = executionEngine;
        }

        public bool UpdateParameter<T>(string parameterName, T value)
        {
            executionEngine.ResetValues();
            var updateSlot = workingMemoryManager.Memory.RootObject[parameterName].Slots[SlotTypes.NewValue] as ISlotUpdate<T>;
            updateSlot?.Update(value,true);
            return executionEngine.FireAllRules();
            
        }

        public bool UpdateCurrentEditedResult(Guid resultId)
        {
            var internalRootObject = workingMemoryManager.Memory.RootObject as IRootObjectInternal;
            internalRootObject?.UpdatedCurrentResultId(resultId);
            executionEngine.LoadResult(resultId);
            return true;
        }

        public bool UpdateExecutionMode(ExecutionMode executionMode)
        {
           this.executionMode = executionMode;
           //TODO update flags
           return true;
        }

        public IEnumerable<IChangeItem> GetChangeList()
        {
            var list = new List<IChangeItem>();
            var collection = workingMemoryManager.Memory.RootObject.FactCollection;
            foreach (var fact in collection)
            {
                if (fact.Value == null)
                {
                    continue;
                }

                var currentValue = fact.Value.GetValue(SlotTypes.CurrentValue);
                var previousValue = fact.Value.GetValue(SlotTypes.PreviousValue);
                if (!currentValue.Equals(previousValue))
                {
                    list.Add(new ChangeItem(fact.Key, currentValue.ToString(), previousValue.ToString()));
                }
                //RulesLogger.Instance.Log($"{fact.Key} : CurrentValue = {currentValue} , PreviousValue = {previousValue}");
            }


            return list;
        }

        public int GetPreviousRulesExecutedCount()
        {
            return executionEngine.GetLastRulesExecutedCount();
        }

        public Guid GetStepId()
        {
            return workingMemoryManager.Memory.RootObject.CurrentStepId;
        }

        public IList<Guid> GetResultIds()
        {
            IList<Guid> resultIds = new List<Guid>();
            foreach (var result in workingMemoryManager.Memory.RootObject.Step.Children)
            {
                resultIds.Add(result.Id);
            }

            return resultIds;
        }
    }
}