using System.Collections.Generic;
using CoreHelper;

namespace Core
{
    public interface IReteNode
    {
        IDictionary<string, IAlphaNode> AlphaNodes { get; set; }

        void ProcessToken(IToken token);

        void AddAlphaNode(string key, IAlphaNode alphaNode);
    }

    public class ReteNode : IReteNode
    {
        public ReteNode()
        {
            AlphaNodes = new Dictionary<string, IAlphaNode>();
        }
        public IDictionary<string, IAlphaNode> AlphaNodes { get; set; }
        public void ProcessToken(IToken token)
        {
            foreach (var alphaNode in AlphaNodes)
            {
                alphaNode.Value.ProcessToken(token);
            }
        }

        public void AddAlphaNode(string key, IAlphaNode alphaNode)
        {
            AlphaNodes[key] = alphaNode;
        }

        public override string ToString()
        {
            return nameof(ReteNode);
        }
    }
}