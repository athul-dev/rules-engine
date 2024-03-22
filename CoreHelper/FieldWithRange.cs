using System;

namespace CoreHelper
{
    public interface IFieldWithRange<T> : IField<T> where T : IComparable<T>
    {
        IRangeSlot<T> Range { get; set; }
    }

    public abstract class FieldWithRange<T> : Field<T>, IFieldWithRange<T> where T : IComparable<T>
    {
        public IRangeSlot<T> Range { get; set; }

        protected FieldWithRange() : base()
        {
            Range = new RangeSlot<T>();
            Slots[SlotTypes.Range] = Range;
            AddSlotPredicate(SlotTypes.Range, RangeIsReactive);
        }

        public override object GetValue(string slotValue)
        {
            if (Slots[slotValue] is IRangeSlot<T> value)
            {
                return value.Range;
            }

            return base.GetValue(slotValue);
        }

        private bool RangeIsReactive(IToken token)
        {
            return token.WorkingMemoryItem.Field is IFieldWithRange<T> field && field.Range.IsReactive;
        }
    }
}