using System;
using System.Collections.Generic;

namespace CoreHelper
{
    public class InputParameter
    {
        public InputParameter(object internalObject)
        {
            this.internalObject = internalObject;
        }

        private object internalObject;

        public void SetValue<T>(T value)
        {
            internalObject = value;
        }

        public T GetValue<T>()
        {
            return (T)internalObject;
        }
    }

    public interface IRuleNode
    {
        IList<Dependency> GetDependencies();

        void Execute(IExecutionContext executionContext);

        event EventHandler Activated;

        void AddInputParameters(string key, string slot, InputParameter param);

        void RemoveInputParameter(string key, string slot);

    }

    public abstract class RuleNode : IRuleNode
    {
        protected RuleNode()
        {
            parameters = new Dictionary<string, Dictionary<string, InputParameter>>();
            dependencyList = new List<Dependency>();
        }

        public void AddInputParameters(string key, string slot, InputParameter param)
        {
            if (!parameters.ContainsKey(key))
            {
                parameters[key] = new Dictionary<string, InputParameter>();
            }
            parameters[key][slot] = param;

            CheckAndActivateTheRule();
        }

        public void RemoveInputParameter(string key, string slot)
        {
            if (parameters.ContainsKey(key) && parameters[key].ContainsKey(slot))
            {
                parameters[key].Remove(slot);
            }

            CheckAndActivateTheRule();
        }

        public void Execute(IExecutionContext executionContext)
        {
            RulesLogger.Instance.Log($"Executing {ToString()}");

            ExecuteInternal(executionContext);
        }

        private void CheckAndActivateTheRule()
        {
            if (dependencyList.Count == 0)
            {
                dependencyList = GetDependencies();
            }

            foreach (var dependency in dependencyList)
            {
                var parameterDependency = dependency as ParameterDependency;
                if (parameterDependency == null)
                {
                    return;
                }
                if (!parameters.ContainsKey(parameterDependency.DependencyName))
                {
                    //Still incomplete
                    return;
                }

                if (!parameters[parameterDependency.DependencyName].ContainsKey(parameterDependency.Slot))
                {
                    //still incomplete
                    return;
                }
            }

            OnActivate();
        }

        private readonly Dictionary<string, Dictionary<string, InputParameter>> parameters;
        private IList<Dependency> dependencyList;

        private void OnActivate()
        {
            Activated?.Invoke(this, new EventArgs());
        }

        public event EventHandler Activated;
        public abstract IList<Dependency> GetDependencies();

        protected abstract void ExecuteInternal(IExecutionContext executionContext);

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}
