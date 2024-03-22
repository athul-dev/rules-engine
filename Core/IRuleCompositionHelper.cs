using System;
using System.Collections.Generic;
using CoreHelper;
using Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces;
using RootObject;

namespace Core
{

    public interface IRulesFactory
    {
        IDictionary<string, IRuleInfo> GetRuleInfo(IRootObject rootObject);
    }

    public class RulesFactory : IRulesFactory
    {
        private RulesBuilderUtil rulesBuilderUtil;

        private readonly IDictionary<StepType, Action<IDictionary<string, IRuleInfo>>> ruleInfosBuilderDictionary = new Dictionary<StepType, Action<IDictionary<string, IRuleInfo>>>();

        public RulesFactory()
        {
            rulesBuilderUtil = new RulesBuilderUtil();

            ruleInfosBuilderDictionary[StepType.Surview] = rulesDictionary =>
            {
                rulesBuilderUtil.AddCTStepRules(rulesDictionary);
                rulesBuilderUtil.AddSurviewRules(rulesDictionary);
            };

            ruleInfosBuilderDictionary[StepType.Axial] = rulesDictionary =>
            {
                rulesBuilderUtil.AddCTStepRules(rulesDictionary);
                rulesBuilderUtil.AddRotatingStepRules(rulesDictionary);
                rulesBuilderUtil.AddAxialRules(rulesDictionary);
            };

            ruleInfosBuilderDictionary[StepType.Helix] = rulesDictionary =>
            {
                rulesBuilderUtil.AddCTStepRules(rulesDictionary);
                rulesBuilderUtil.AddRotatingStepRules(rulesDictionary);
                rulesBuilderUtil.AddHelixRules(rulesDictionary);
            };

        }

        public IDictionary<string, IRuleInfo> GetRuleInfo(IRootObject rootObject)
        {
            IDictionary<string, IRuleInfo> rulesDictionary = new Dictionary<string, IRuleInfo>();
            if (ruleInfosBuilderDictionary.ContainsKey(rootObject.Type))
            {
                ruleInfosBuilderDictionary[rootObject.Type].Invoke(rulesDictionary);
            }

            return rulesDictionary;
        }
    }


    public interface IRuleCompositionHelper
    {

        IReteNode GetReteGraph(IDictionary<string, IRuleInfo> ruleInfos, IRootObject rootObject);

    }

    public class RuleCompositionHelper: IRuleCompositionHelper
    {
        //public IDictionary<string, IRuleInfo> LoadRules(string assemblyName)
        //{
        //    IDictionary<string, IRuleInfo> rules = new Dictionary<string, IRuleInfo>();

        //    Assembly assembly = Assembly.LoadFrom(assemblyName);

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
        //                rules[rA.RuleName] = new RuleInfo(rA.RuleName, rA.Priority, rA.Category, ruleNode,
        //                    rA.IsLocalField);
        //            }
        //        }
        //    }
        //    return rules;
        //}

        //public IDictionary<string, IRuleInfo> LoadRules(string assemblyName, StepType stepType)
        //{
        //    IDictionary<string, IRuleInfo> rules = new Dictionary<string, IRuleInfo>();

        //    Assembly assembly = Assembly.LoadFrom(assemblyName);

        //    var classes = assembly.GetTypes();

        //    foreach (var cls in classes)
        //    {
        //        var attributes = cls.GetCustomAttributes(typeof(RuleAttribute), false);
        //        if (attributes.Length > 0)
        //        {
        //            var rA = attributes[0] as RuleAttribute;
        //            var category = rA.Category.ToString();
        //            if (rA.Category.ToString() == stepType.ToString() || rA.Category == Category.CTStep)
        //            {
        //                if (rA == null)
        //                {
        //                    continue;
        //                }
        //                var ctor = cls.GetConstructor(new Type[] { });
        //                var classObject = ctor?.Invoke(new object[] { });

        //                if (classObject is IRuleNode ruleNode)
        //                {
        //                    rules[rA.RuleName] = new RuleInfo(rA.RuleName, rA.Priority, rA.Category, ruleNode,
        //                        rA.IsLocalField);
        //                }
        //            }
        //        }
        //    }
        //    return rules;
        //}

        public IReteNode GetReteGraph(IDictionary<string, IRuleInfo> ruleInfos, IRootObject rootObject)
        {
            IReteNode reteNode = new ReteNode();
            IDictionary<string, AlphaNode> alphaNodes = GetAllPossibleAlphaNodes(rootObject);

            foreach (var val in ruleInfos)
            {
                IList<Dependency> dependencies = val.Value.RuleNode.GetDependencies();

                foreach (var dependency in dependencies)
                {
                    IAlphaNode alphaIsANode = CreateIsAAlphaNode(reteNode, alphaNodes, dependency as ParameterDependency, val.Value.RuleNode);

                    IAlphaNode slotAlphaNode = CreateSlotAlphaNode(dependency as ParameterDependency, val.Value.RuleName, alphaIsANode);

                    IBetaNode betaNode = CreateBetaNode(slotAlphaNode, dependency as ParameterDependency, val.Value.RuleNode);
                }
            }

            return reteNode;
        }

        public IAlphaNode CreateIsAAlphaNode(IReteNode reteNode, IDictionary<string, AlphaNode> alphaNodes, ParameterDependency dependency, IRuleNode ruleNode)
        {
            IAlphaNode alphaIsANode;

            if (!reteNode.AlphaNodes.ContainsKey(dependency.DependencyName))
            {
                if (!alphaNodes.ContainsKey(dependency.DependencyName))
                {
                    throw new Exception(
                        $"Parameter = {dependency.DependencyName} not added to the Root Object");
                }

                alphaIsANode = alphaNodes[dependency.DependencyName];
                reteNode.AlphaNodes.Add(dependency.DependencyName, alphaIsANode);
            }
            else
            {
                alphaIsANode = reteNode.AlphaNodes[dependency.DependencyName];
            }

            if (dependency.Slot == SlotTypes.Empty && !alphaIsANode.BetaNodes.ContainsKey(dependency.Slot))
            {
                var emptyBetaNode = new EmptyBetaMode(dependency.DependencyName, dependency.Slot);
                emptyBetaNode.RuleNodes.Add(ruleNode);
                alphaIsANode.BetaNodes[dependency.Slot] = emptyBetaNode;
                //continue;
            }

            return alphaIsANode;
        }

        public IAlphaNode CreateSlotAlphaNode(ParameterDependency dependency, string ruleName, IAlphaNode alphaIsANode)
        {
            IAlphaNode slotAlphaNode;
            var key = dependency.Predicate != null ? ruleName + dependency.DependencyName + dependency.Slot + "Custom" : dependency.Slot;
            if (!alphaIsANode.ChildNodes.ContainsKey(key))
            {
                if (dependency.Predicate == null)
                {
                    slotAlphaNode = new AlphaNodeSlotIsReactive(dependency.DependencyName, dependency.Slot);
                }
                else
                {
                    slotAlphaNode = new AlphaNodeWithUserPredicate(dependency.DependencyName, dependency.Slot, dependency.Predicate);
                }

                alphaIsANode.ChildNodes[key] = slotAlphaNode;
            }
            else
            {
                slotAlphaNode = alphaIsANode.ChildNodes[key];
            }

            //if (slotAlphaNode == null)
            //{
            //    continue;
            //}

            return slotAlphaNode;
        }

        public IBetaNode CreateBetaNode(IAlphaNode slotAlphaNode, ParameterDependency dependency, IRuleNode ruleNode)
        {
            IBetaNode betaNode;
            if (!slotAlphaNode.BetaNodes.ContainsKey(dependency.Slot))
            {
                betaNode = new SlotValueBetaMode(dependency.DependencyName, dependency.Slot);
                slotAlphaNode.BetaNodes.Add(dependency.Slot, betaNode);
            }
            else
            {
                betaNode = slotAlphaNode.BetaNodes[dependency.Slot];
            }

            betaNode.RuleNodes.Add(ruleNode);

            return betaNode;
        }


        private IDictionary<string, AlphaNode> GetAllPossibleAlphaNodes(IRootObject rootObject)
        {
            Dictionary<string, AlphaNode> alphaNodeDictionary = new Dictionary<string, AlphaNode>();

            foreach (var fact in rootObject.FactCollection)
            {
                if (fact.Value == null)
                {
                    continue;
                }

                alphaNodeDictionary[fact.Key] = new AlphaNodeIsAType(fact.Value.GetType());
            }

            return alphaNodeDictionary;
        }


        #region Commented Code

        //public IReteNode CreateNodes(IDictionary<string, IRuleInfo> ruleInfos, IRootObject rootObject)
        //{
        //    IReteNode reteNode = new ReteNode();
        //    IDictionary<string, AlphaNode> alphaNodes = GetAllPossibleAlphaNodes(rootObject);

        //    foreach (var val in ruleInfos)
        //    {
        //        IList<Dependency> dependencies = val.Value.RuleNode.GetDependencies();

        //        foreach (var dependency in dependencies)
        //        {
        //            IAlphaNode alphaIsANode;

        //            if (!reteNode.AlphaNodes.ContainsKey(dependency.ParameterName))
        //            {
        //                if (!alphaNodes.ContainsKey(dependency.ParameterName))
        //                {
        //                    throw new Exception(
        //                        $"Parameter = {dependency.ParameterName} not added to the Root Object");
        //                }

        //                alphaIsANode = alphaNodes[dependency.ParameterName];
        //                reteNode.AlphaNodes.Add(dependency.ParameterName, alphaIsANode);
        //            }
        //            else
        //            {
        //                alphaIsANode = reteNode.AlphaNodes[dependency.ParameterName];
        //            }

        //            if (dependency.Slot == SlotTypes.Empty && !alphaIsANode.BetaNodes.ContainsKey(dependency.Slot))
        //            {
        //                var emptyBetaNode = new EmptyBetaMode(dependency.ParameterName, dependency.Slot);
        //                emptyBetaNode.RuleNodes.Add(val.Value.RuleNode);
        //                alphaIsANode.BetaNodes[dependency.Slot] = emptyBetaNode;
        //                continue;
        //            }

        //            IAlphaNode slotAlphaNode;
        //            var key = dependency.Predicate != null ? val.Value.RuleName + dependency.ParameterName + dependency.Slot + "Custom" : dependency.Slot;
        //            if (!alphaIsANode.ChildNodes.ContainsKey(key))
        //            {
        //                if (dependency.Predicate == null)
        //                {
        //                    slotAlphaNode = new AlphaNodeSlotIsReactive(dependency.ParameterName, dependency.Slot);
        //                }
        //                else
        //                {
        //                    slotAlphaNode = new AlphaNodeWithUserPredicate(dependency.ParameterName, dependency.Slot, dependency.Predicate);
        //                }

        //                alphaIsANode.ChildNodes[key] = slotAlphaNode;
        //            }
        //            else
        //            {
        //                slotAlphaNode = alphaIsANode.ChildNodes[key];
        //            }

        //            if (slotAlphaNode == null)
        //            {
        //                continue;
        //            }

        //            IBetaNode betaNode;
        //            if (!slotAlphaNode.BetaNodes.ContainsKey(dependency.Slot))
        //            {
        //                betaNode = new SlotValueBetaMode(dependency.ParameterName, dependency.Slot);
        //                slotAlphaNode.BetaNodes.Add(dependency.Slot, betaNode);
        //            }
        //            else
        //            {
        //                betaNode = slotAlphaNode.BetaNodes[dependency.Slot];
        //            }

        //            betaNode.RuleNodes.Add(val.Value.RuleNode);
        //        }
        //    }

        //    return reteNode;
        //}


        //public IAlphaNode CreateAlphaNodes(IRootObject rootObject)
        //{
        //    throw new NotImplementedException();
        //}

        //public IBetaNode CreateBetaNodes(IRootObject rootObject)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

    }
}
