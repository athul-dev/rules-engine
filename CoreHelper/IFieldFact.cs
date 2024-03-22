namespace CoreHelper
{
    public interface IFieldFact : IFact
    {
        void Reset();

        void Revert();
    }
}