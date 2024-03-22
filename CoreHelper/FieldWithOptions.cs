namespace CoreHelper
{
    public interface IFieldWithOptions<T> : IField<T>
    {
        IOptionSlot<T> Options { get; set; }
    }

    public abstract class FieldWithOptions<T> : Field<T>, IFieldWithOptions<T>
    {
        public IOptionSlot<T> Options { get; set; }

        protected FieldWithOptions() : base()
        {
            Options = new OptionSlot<T>();
            Slots[SlotTypes.Options] = Options;
            AddSlotPredicate(SlotTypes.Options, OptionIsReactive);
        }

        private bool OptionIsReactive(IToken token)
        {
            return token.WorkingMemoryItem.Field is IFieldWithOptions<T> field && field.Options.IsReactive;
        }

        public override object GetValue(string slotValue)
        {
            if (Slots[slotValue] is IOptionSlot<T> value)
            {
                return value.Options;
            }

            return base.GetValue(slotValue);
        }
    }
}