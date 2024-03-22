using System.Collections.Generic;
using CoreHelper;

namespace Core
{
    public interface IReteGraph
    {
        IReteNode HeadNode { get; }

        IDictionary<string, IRuleInfo> RuleNodeInfos { get; }
    }

    public class ReteGraph: IReteGraph
    {
        public ReteGraph(IReteNode headNode, IDictionary<string, IRuleInfo> ruleNodeInfos)
        {
            HeadNode = headNode;
            RuleNodeInfos = ruleNodeInfos;
        }

        public IReteNode HeadNode { get; }
        public IDictionary<string, IRuleInfo> RuleNodeInfos { get; }
    }
}