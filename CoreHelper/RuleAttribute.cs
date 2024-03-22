using System;

namespace CoreHelper
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RuleAttribute : Attribute
    {
        public string RuleName { get; private set; }
        public int Priority { get; }
        public Category Category { get; }
        public bool AutoFocus { get; }

        public bool IsLocalField { get; }

        public RuleAttribute(string ruleName, int priority, bool isLocalField = false, Category category = Category.CTStep, bool autoFocus = true)
        {
            RuleName = ruleName;
            Priority = priority;
            IsLocalField = isLocalField;
            Category = category;
            AutoFocus = autoFocus;
        }
    }
}