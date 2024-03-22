using System;

namespace CoreHelper
{
    public abstract class Dependency
    {
        protected Dependency(string parameterName)
        {
            DependencyName = parameterName;
        }
        public string DependencyName { get; }
    }

    public class ParameterDependency : Dependency
    {
        public ParameterDependency(string parameterName, string slot) : base(parameterName)
        {
            Slot = slot;
        }
        public ParameterDependency(string parameterName, string slot, Predicate<IFact> predicate) : this(parameterName, slot)
        {
            Predicate = predicate;
        }

        public string Slot { get; }

        public Predicate<IFact> Predicate { get; }
    }

    public class FlagDependency : Dependency
    {
        public FlagDependency(string flagName, bool expectedValue) : base(flagName)
        {
            ExpectedValue = expectedValue;
        }

        public bool ExpectedValue { get; }
    }
}
