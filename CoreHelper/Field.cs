using System;
using System.Collections.Generic;

namespace CoreHelper
{
    public interface IField<T> : IFieldFact
    {
        IValueSlot<T> CurrentValue { get; set; }

        IValueSlot<T> PreviousValue { get; set; }

        IValueSlot<T> NewValue { get; set; }
    }

    public abstract class Field<T> : IField<T>
    {
        protected Field()
        {
            Slots = new Dictionary<string, ISlot>();
            SlotPredicates = new Dictionary<string, Predicate<IToken>>();
            CurrentValue = new ValueSlot<T>();
            NewValue = new ValueSlot<T>();
            PreviousValue = new ValueSlot<T>();
            InitializeSlotPredicates();
        }

        public IValueSlot<T> CurrentValue
        {
            get => Slots.ContainsKey(SlotTypes.CurrentValue) ? Slots[SlotTypes.CurrentValue] as IValueSlot<T> : null;
            set => Slots[SlotTypes.CurrentValue] = value;
        }

        public IValueSlot<T> PreviousValue
        {
            get => Slots.ContainsKey(SlotTypes.PreviousValue) ? Slots[SlotTypes.PreviousValue] as IValueSlot<T> : null;
            set => Slots[SlotTypes.PreviousValue] = value;
        }

        public IValueSlot<T> NewValue
        {
            get => Slots.ContainsKey(SlotTypes.NewValue) ? Slots[SlotTypes.NewValue] as IValueSlot<T> : null;
            set => Slots[SlotTypes.NewValue] = value;
        }

        public IDictionary<string, Predicate<IToken>> SlotPredicates { get; }
        public IDictionary<string, ISlot> Slots { get; }
        public string Name { get; set; }
        public Type Type => typeof(T);

        protected void AddSlotPredicate(string slotType, Predicate<IToken> predicate)
        {
            SlotPredicates[slotType] = predicate;
        }

        private void InitializeSlotPredicates()
        {
            AddSlotPredicate(SlotTypes.CurrentValue, CurrentValueIsReactive);
            AddSlotPredicate(SlotTypes.NewValue, NewValueIsReactive);
            AddSlotPredicate(SlotTypes.PreviousValue, PreviousValueIsReactive);
        }

        private bool CurrentValueIsReactive(IToken token)
        {
            return token.WorkingMemoryItem.Field is IField<T> field && field.CurrentValue != null && field.CurrentValue.IsReactive;
        }

        private bool NewValueIsReactive(IToken token)
        {
            return token.WorkingMemoryItem.Field is IField<T> field && field.NewValue != null && field.NewValue.IsReactive;
        }

        private bool PreviousValueIsReactive(IToken token)
        {
            return token.WorkingMemoryItem.Field is IField<T> field && field.PreviousValue != null && field.PreviousValue.IsReactive;
        }

        public virtual object GetValue(string slotValue)
        {
            if (Slots[slotValue] is IValueSlot<T> value)
            {
                return value.Value;
            }
            return default(T);
        }

        public void Reset()
        {
            if (PreviousValue is ISlotUpdate<T> previousVal)
            {
                previousVal.Update(CurrentValue.Value, false);
            }

            if (NewValue is ISlotUpdate<T> newValue)
            {
                newValue.Update(CurrentValue.Value, false);
            }
        }

        public void Revert()
        {
            if (CurrentValue is ISlotUpdate<T> currentValue)
            {
                currentValue.Update(PreviousValue.Value, false);
            }
        }
    }
}