using System;
using System.Collections.Generic;

namespace CoreHelper
{
    public interface IFlagFact : IFact
    {
        IValueSlot<bool> FlagValue { get; }
    }

    public class FlagField : IFlagFact
    {
        public FlagField(string flagName, bool expectedValue)
        {
            this.flagName = flagName;
            this.expectedValue = expectedValue;
            Slots = new Dictionary<string, ISlot>();
            SlotPredicates = new Dictionary<string, Predicate<IToken>>();
            FlagValue = new ValueSlot<bool>();
            Slots[flagName] = FlagValue;
            SlotPredicates[flagName] = FlagIsExpected;
        }

        public string Name => flagName;
        public Type Type => typeof(bool);
        public IDictionary<string, Predicate<IToken>> SlotPredicates { get; }
        public IDictionary<string, ISlot> Slots { get; }
        public object GetValue(string slotValue)
        {
            return FlagValue.Value;
        }

        public IValueSlot<bool> FlagValue { get; }

        private bool FlagIsExpected(IToken token)
        {
            return token.WorkingMemoryItem.Field is IFlagFact fact && fact.FlagValue.Value == expectedValue;
        }

        private readonly string flagName;
        private readonly bool expectedValue;
    }
}