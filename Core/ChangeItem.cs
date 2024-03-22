namespace Core
{
    public interface IChangeItem
    {
        string FieldName { get; }

        string Value { get; }

        string PreviousValue { get; }
    }

    public class ChangeItem:IChangeItem
    {
        public ChangeItem(string fieldName, string value, string previousValue)
        {
            FieldName = fieldName;
            Value = value;
            PreviousValue = previousValue;
        }

        public string FieldName { get; }
        public string Value { get; }
        public string PreviousValue { get; }
    }
}