using System.Collections.Generic;
using CoreHelper;

namespace Core
{
    public interface IBetaNode
    {
        IList<IRuleNode> RuleNodes { get; }
        void AssimilateData(IToken token);

        void RetractData(IToken token);
    }

    public abstract class BetaNode : IBetaNode
    {
        protected BetaNode(string name, string slot)
        {
            this.ParameterName = name;
            this.SlotName = slot;
            RuleNodes = new List<IRuleNode>();
        }


        public IList<IRuleNode> RuleNodes { get; }
        public abstract void AssimilateData(IToken token);
        public abstract void RetractData(IToken token);
        
        protected readonly string ParameterName;

        
        protected readonly string SlotName;

        public override string ToString()
        {
            return ParameterName + SlotName + nameof(BetaNode);
        }
    }

    public class SlotValueBetaMode : BetaNode
    {
        public SlotValueBetaMode(string name, string slot) : base(name, slot)
        {
        }

        public override void AssimilateData(IToken token)
        {
            var field = token.WorkingMemoryItem.Field;

            var value = field?.GetValue(SlotName);

            foreach (var ruleNode in RuleNodes)
            {
                ruleNode.AddInputParameters(ParameterName, SlotName, new InputParameter(value));
            }
        }

        public override void RetractData(IToken token)
        {
            foreach (var ruleNode in RuleNodes)
            {
                ruleNode.RemoveInputParameter(ParameterName, SlotName);
            }
        }
    }

    public class EmptyBetaMode : BetaNode
    {
        public EmptyBetaMode(string name, string slot) : base(name, slot)
        {
        }
        public override void AssimilateData(IToken token)
        {
            foreach (var ruleNode in RuleNodes)
            {
                ruleNode.AddInputParameters(ParameterName, SlotName, new InputParameter("Empty"));
            }
        }

        public override void RetractData(IToken token)
        {
            foreach (var ruleNode in RuleNodes)
            {
                ruleNode.RemoveInputParameter(ParameterName, SlotName);
            }
        }
    }


}