using ERGenerator;

namespace CoreHelper
{
    public interface IFactBuilderUtil
    {
        TK GetFact<T, TK>(DataModel ruleDataModel, string parameterName);

        TK GetEmptyFact<T, TK>();
    }
}