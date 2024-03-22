namespace CoreHelper
{
    public interface IRuleInfo
    {
        string RuleName { get; }

        int RulePriority { get; }

        Category RuleCategory { get; }

        bool IsLocalField { get; }

        IRuleNode RuleNode { get; }
    }

    public class RuleInfo :IRuleInfo
    {
        public RuleInfo(string ruleName, int rulePriority, Category ruleCategory, IRuleNode ruleNode, bool isLocalField)
        {
            RuleName = ruleName;
            RulePriority = rulePriority;
            RuleCategory = ruleCategory;
            RuleNode = ruleNode;
            IsLocalField = isLocalField;
        }

        public string RuleName { get; }

        public int RulePriority { get; }

        public Category RuleCategory { get; }

        public bool IsLocalField { get; }

        public IRuleNode RuleNode { get; }
    }
}