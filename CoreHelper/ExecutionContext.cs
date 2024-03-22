using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace CoreHelper
{
    public enum ExecutionMode
    {
        Online,

        Offline,

        Generate,
    }

    public static class FlagNames
    {

    }

    public interface IFlags
    {
        bool this[string key] { get; set; }
    }


    public class Flags : IFlags
    {
        private IDictionary<string, bool> internalFlagDictionary = new Dictionary<string, bool>();

        public bool this[string key]
        {
            get => internalFlagDictionary.ContainsKey(key) && internalFlagDictionary[key];
            set => internalFlagDictionary[key] = value;
        }
    }

    public interface ILicense
    {
        bool this[string key] { get; set; }
    }

    public class Licenses : ILicense
    {
        private IDictionary<string, bool> internalLicenseDictionary = new Dictionary<string, bool>();

        public bool this[string key]
        {
            get => internalLicenseDictionary.ContainsKey(key) && internalLicenseDictionary[key];
            set => internalLicenseDictionary[key] = value;
        }
    }

    public interface IExecutionContextInternal : IExecutionContext
    {
        void Initialize(Action cancellation);
    }

    public interface IExecutionContext
    {
        ExecutionMode ExecutionMode { get; }

        IExternalDecisionProvider ExternalDecisionProvider { get; }

        IRootObject RootObject { get; }

        //IFlags Flags { get; }

        //ILicense License { get; }

        void ModifyCurrentValue<T>(string parameter, T value);

        void ModifySlotValue<T>(string parameter, string slotType, T value);

        void HaltExecution();

    }

    public class ExecutionContext : IExecutionContextInternal
    {
        public ExecutionContext(IRootObject rootObject, ExecutionMode executionMode, IExternalDecisionProvider externalDecisionProvider)
        {
            //Flags = flags;
            RootObject = rootObject;
            ExecutionMode = executionMode;
            ExternalDecisionProvider = externalDecisionProvider;
            //License = license;
        }

        public void Initialize(Action cancellation)
        {
            this.cancellation = cancellation;
        }

        public ExecutionMode ExecutionMode { get; }
        public IExternalDecisionProvider ExternalDecisionProvider { get; }
        public IRootObject RootObject { get; }
        //public IFlags Flags { get; }
        //public ILicense License { get; }


        public void ModifyCurrentValue<T>(string parameter, T value)
        {
            var parameterObj = RootObject[parameter];

            if (parameterObj == null)
            {
                throw new Exception($"{parameter} Cannot be updated as it doesn't exist in RootObject");
            }

            var currentSlot = parameterObj.Slots[SlotTypes.CurrentValue] as ValueSlot<T>;
            var newSlot = parameterObj.Slots[SlotTypes.NewValue] as ValueSlot<T>;
            var previousSlot = parameterObj.Slots[SlotTypes.PreviousValue] as ValueSlot<T>;

            if (currentSlot == null || newSlot == null || previousSlot == null)
            {
                throw new Exception("Type mismatch exception");
            }

            if (value.Equals(currentSlot.Value))
            {
                RulesLogger.Instance.Log($"Edit Failed=> {parameter}: Updated Value: {value}, ExitingValue: {currentSlot.Value} are same");
                return;
            }

            RulesLogger.Instance.Log($"Edit => {parameter}: Updated Value: {value}, ExitingValue: {currentSlot.Value}");


            if (previousSlot.Value.Equals(currentSlot.Value))
            {
                previousSlot.Update(currentSlot.Value, false);
            }
            newSlot.Update(value, false);
            currentSlot.Update(value, true);
        }

        public void ModifySlotValue<T>(string parameter, string slotType, T value)
        {
            if (slotType == SlotTypes.CurrentValue)
            {
                ModifyCurrentValue(parameter, value);
            }

            if (nonEditableSlots.Contains(slotType))
            {
                throw new Exception($"{slotType} cannot be edited by Rule Node");
            }

            var parameterObj = RootObject[parameter];

            if (parameterObj == null)
            {
                throw new Exception($"{parameter} Cannot be updated as it doesn't exist in RootObject");
            }

            if (!parameterObj.Slots.ContainsKey(slotType))
            {
                throw new Exception($"{slotType} does not exist for {parameter}. Parameter cannot be updated");
            }

            if (parameterObj.Slots[slotType] is ISlotUpdate<T> updateSlot)
            {
                string opt = value.ToString();
                if (value is IEnumerable enumerator)
                {
                    opt = string.Empty;
                    foreach (var v in enumerator)
                    {
                        opt += v + ", ";
                    }
                }
                RulesLogger.Instance.Log($"Edit => {parameter}: {slotType} Updated Value: {opt}");
                updateSlot.Update(value, true);
            }
            else
            {
                throw new Exception("Type mismatch exception");
            }
        }

        public void HaltExecution()
        {
            cancellation?.Invoke();
        }

        private Action cancellation;

        private readonly IList<string> nonEditableSlots = new List<string>() { SlotTypes.NewValue, SlotTypes.PreviousValue };

    }
}
