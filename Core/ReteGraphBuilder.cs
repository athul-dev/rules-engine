using System.Collections.Generic;
using CoreHelper;

namespace Core
{
    public interface IReteGraphBuilder
    {
        //IReteGraph GetReteGraph(string ruleAssemblyPath, IRuleCompositionHelper ruleCompositionHelper, IRootObject rootObject);

        IReteGraph GetReteGraph(IDictionary<string, IRuleInfo> ruleInfos, IRuleCompositionHelper ruleCompositionHelper,
            IRootObject rootObject);

        #region CommentedCode

        //IReteGraph GetReteGraph(string ruleAssemblyPath, IRootObject rootObject);

        #endregion

    }

    public class ReteGraphBuilder : IReteGraphBuilder
    {
        //public IReteGraph GetReteGraph(string assemblyName, IRuleCompositionHelper ruleCompositionHelper, IRootObject rootObject)
        //{
        //    var ruleInfos = ruleCompositionHelper.LoadRules(assemblyName);
        //    return GetReteGraph(ruleInfos, ruleCompositionHelper, rootObject);
        //}

        public IReteGraph GetReteGraph(IDictionary<string, IRuleInfo> ruleInfos,
            IRuleCompositionHelper ruleCompositionHelper, IRootObject rootObject)
        {
            return new ReteGraph(ruleCompositionHelper.GetReteGraph(ruleInfos, rootObject), ruleInfos);
        }

        #region Commented Code

        //public IReteGraph GetReteGraph(string ruleAssemblyPath, IRootObject rootObject)
        //{
        //    IReteNode reteNode = new ReteNode();
        //    Dictionary<string, IRuleInfo> rules = new Dictionary<string, IRuleInfo>();
        //    Dictionary<string, AlphaNode> alphaNodes = GetAllPossibleAlphaNodes(rootObject);

        //    Assembly assembly = Assembly.LoadFrom(ruleAssemblyPath);

        //    var classes = assembly.GetTypes();

        //    foreach (var cls in classes)
        //    {
        //        var attributes = cls.GetCustomAttributes(typeof(RuleAttribute), false);
        //        if (attributes.Length > 0)
        //        {
        //            var rA = attributes[0] as RuleAttribute;
        //            if (rA == null)
        //            {
        //                continue;
        //            }
        //            var ctor = cls.GetConstructor(new Type[] { });
        //            var classObject = ctor?.Invoke(new object[] { });

        //            if (classObject is IRuleNode ruleNode)
        //            {
        //                rules[rA.RuleName] = new RuleInfo(rA.RuleName, rA.Priority, rA.Category, ruleNode, rA.IsLocalField);
        //                IList<Dependency> dependencies = ruleNode.GetDependencies();

        //                foreach (var dependency in dependencies)
        //                {
        //                    IAlphaNode alphaIsANode;

        //                    if (!reteNode.AlphaNodes.ContainsKey(dependency.ParameterName))
        //                    {
        //                        if (!alphaNodes.ContainsKey(dependency.ParameterName))
        //                        {
        //                            throw new Exception($"Parameter = {dependency.ParameterName} not added to the Root Object");
        //                        }
        //                        alphaIsANode = alphaNodes[dependency.ParameterName];
        //                        reteNode.AlphaNodes.Add(dependency.ParameterName, alphaIsANode);
        //                    }
        //                    else
        //                    {
        //                        alphaIsANode = reteNode.AlphaNodes[dependency.ParameterName];
        //                    }

        //                    if (dependency.Slot == SlotTypes.Empty && !alphaIsANode.BetaNodes.ContainsKey(dependency.Slot))
        //                    {
        //                        var emptyBetaNode = new EmptyBetaMode(dependency.ParameterName, dependency.Slot);
        //                        emptyBetaNode.RuleNodes.Add(ruleNode);
        //                        alphaIsANode.BetaNodes[dependency.Slot] = emptyBetaNode;
        //                        continue;
        //                    }

        //                    IAlphaNode slotAlphaNode;
        //                    var key = dependency.Predicate != null ? rA.RuleName + dependency.ParameterName + dependency.Slot + "Custom" : dependency.Slot;
        //                    if (!alphaIsANode.ChildNodes.ContainsKey(key))
        //                    {
        //                        if (dependency.Predicate == null)
        //                        {
        //                            slotAlphaNode = new AlphaNodeSlotIsReactive(dependency.ParameterName, dependency.Slot);
        //                        }
        //                        else
        //                        {
        //                            slotAlphaNode = new AlphaNodeWithUserPredicate(dependency.ParameterName, dependency.Slot, dependency.Predicate);
        //                        }

        //                        alphaIsANode.ChildNodes[key] = slotAlphaNode;
        //                    }
        //                    else
        //                    {
        //                        slotAlphaNode = alphaIsANode.ChildNodes[key];
        //                    }

        //                    if (slotAlphaNode == null)
        //                    {
        //                        continue;
        //                    }

        //                    IBetaNode betaNode;
        //                    if (!slotAlphaNode.BetaNodes.ContainsKey(dependency.Slot))
        //                    {
        //                        betaNode = new SlotValueBetaMode(dependency.ParameterName, dependency.Slot);
        //                        slotAlphaNode.BetaNodes.Add(dependency.Slot, betaNode);
        //                    }
        //                    else
        //                    {
        //                        betaNode = slotAlphaNode.BetaNodes[dependency.Slot];
        //                    }

        //                    betaNode.RuleNodes.Add(ruleNode);

        //                }
        //            }

        //        }

        //    }

        //    return new ReteGraph(reteNode, rules);
        //}


        //private Dictionary<string, AlphaNode> GetAllPossibleAlphaNodes(IRootObject rootObject)
        //{
        //    Dictionary<string, AlphaNode> alphaNodeDictionary = new Dictionary<string, AlphaNode>();

        //    foreach (var fact in rootObject.FactCollection)
        //    {
        //        if (fact.Value == null)
        //        {
        //            continue;
        //        }

        //        alphaNodeDictionary[fact.Key] = new AlphaNodeIsAType(fact.Value.GetType());
        //    }

        //    return alphaNodeDictionary;
        //}

        #endregion
    }
}