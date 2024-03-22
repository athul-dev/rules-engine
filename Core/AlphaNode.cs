using System;
using System.Collections.Generic;
using CoreHelper;


namespace Core
{
    //public interface IAlphaMemory
    //{
    //    IDictionary<Guid, IToken> TokenDictionary { get; }
    //}


    public interface IAlphaNode
    {
        IDictionary<string, IAlphaNode> ChildNodes { get; }

        IDictionary<string, IBetaNode> BetaNodes { get; }

        void AddChildNode(string slotType, IAlphaNode childNode);

        void AddBetaNode(string slotType, IBetaNode betaNode);

        void ProcessToken(IToken token);
    }

    public abstract class AlphaNode : IAlphaNode
    {
        protected AlphaNode()
        {
            ChildNodes = new Dictionary<string, IAlphaNode>();
            BetaNodes = new Dictionary<string, IBetaNode>();
        }

        public IDictionary<string, IAlphaNode> ChildNodes { get; }

        public IDictionary<string, IBetaNode> BetaNodes { get; }

        public void AddChildNode(string slotType, IAlphaNode childNode)
        {
            if (childNode != null)
            {
                ChildNodes.Add(slotType, childNode);
            }
        }

        public void AddBetaNode(string slotType, IBetaNode betaNode)
        {
            if (betaNode != null)
            {
                BetaNodes.Add(slotType, betaNode);
            }
        }

        public virtual void ProcessToken(IToken token)
        {
            if (Match(token))
            {
                InternalToken[token.Id] = token;

                PropagateTokenToChildAlphaNode(token);

                PropagateTokenToBetaNode(token);
                
            }
        }

        protected void PropagateTokenToChildAlphaNode(IToken token)
        {
            foreach (var childNode in ChildNodes)
            {
                childNode.Value.ProcessToken(token);
            }
        }

        protected void PropagateTokenToBetaNode(IToken token)
        {
            foreach (var betaNode in BetaNodes)
            {
                betaNode.Value.AssimilateData(token);
            }
        }
        protected void SubscribeToChangeEvent(IToken token, string slotName)
        {
            if (token.WorkingMemoryItem.Field.Slots.ContainsKey(slotName))
            {
                token.WorkingMemoryItem.Field.Slots[slotName].PropertyChanged += (sender, e) => ValueChanged(sender, e, token.Id);
            }
        }

        protected void ValueChanged(object sender, EventArgs e, Guid id)
        {
            ProcessToken(InternalToken[id]);
        }

        protected abstract bool Match(IToken token);

        protected IDictionary<Guid, IToken> InternalToken = new Dictionary<Guid, IToken>();
    }

    public class AlphaNodeIsAType : AlphaNode
    {
        private readonly Type type;

        public AlphaNodeIsAType(Type type)
        {
            this.type = type;
        }

        protected override bool Match(IToken token)
        {
            return token.WorkingMemoryItem.Field.GetType() == type;
        }

        public override string ToString()
        {
            return type.Name + nameof(AlphaNodeIsAType);
        }
    }

    public class AlphaNodeSlotIsReactive : AlphaNode
    {
        private readonly string parameterName;
        protected readonly string SlotName;

        public AlphaNodeSlotIsReactive(string parameterName, string slotName)
        {
            this.parameterName = parameterName;
            SlotName = slotName;
        }

        protected override bool Match(IToken token)
        {
            if (token.WorkingMemoryItem.Field.SlotPredicates.ContainsKey(SlotName))
            {
                return token.WorkingMemoryItem.Field.SlotPredicates[SlotName].Invoke(token);

            }
            return false;
        }

        public override void ProcessToken(IToken token)
        {
            if (!InternalToken.ContainsKey(token.Id))
            {
                InternalToken[token.Id] = token;
                SubscribeToChangeEvent(token, SlotName);
            }

            base.ProcessToken(token);
        }

        public override string ToString()
        {
            return parameterName + SlotName + nameof(AlphaNodeSlotIsReactive);
        }
    }

    public class AlphaNodeWithUserPredicate : AlphaNodeSlotIsReactive
    {
        private readonly Predicate<IFact> userPredicate;

        protected override bool Match(IToken token)
        {
            return userPredicate(token.WorkingMemoryItem.Field);
        }

        public AlphaNodeWithUserPredicate(string parameterName, string slotName, Predicate<IFact> predicate) : base(parameterName, slotName)
        {
            userPredicate = predicate;
        }

        public override void ProcessToken(IToken token)
        {
            base.ProcessToken(token);
            if (!Match(token))
            {
                foreach (var betaNode in BetaNodes)
                {
                    betaNode.Value.RetractData(token);
                }
            }
        }

        public override string ToString()
        {
            return SlotName + nameof(AlphaNodeWithUserPredicate);
        }
    }

    public class AlphaNodeFlagCheck : AlphaNode
    {
        private readonly string flagName;
        private readonly bool expectedValue;

        public AlphaNodeFlagCheck(string flagName, bool expectedValue)
        {
            this.flagName = flagName;
            this.expectedValue = expectedValue;
        }

        protected override bool Match(IToken token)
        {
            return token.WorkingMemoryItem.Field.SlotPredicates[flagName].Invoke(token) == expectedValue;
        }


        public override string ToString()
        {
            return flagName + expectedValue + nameof(AlphaNodeFlagCheck);
        }
    }

}