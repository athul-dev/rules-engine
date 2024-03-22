using System.Collections.Generic;
using CoreHelper;

namespace RootObjectGenerator
{
    public class RootObjectHelper
    {
        private static bool isInitialized = false;

        public static Dictionary<ParameterType, string> InterfaceNameWithInheritanceStrings = new Dictionary<ParameterType, string>();
        public static Dictionary<ParameterType, string> ClassNameWithInheritanceStrings = new Dictionary<ParameterType, string>();
        public static Dictionary<ParameterType, string> CtorString = new Dictionary<ParameterType, string>();
        public static Dictionary<ParameterType, string> ParameterFactoryMethodNameString = new Dictionary<ParameterType, string>();
        public static Dictionary<Category, string> RuleFactoryMethodNameString = new Dictionary<Category, string>();

        public static void Initialize()
        {
            if(isInitialized)
            {
                return;
            }
            InterfaceNameWithInheritanceStrings[ParameterType.CTStep] = "public interface ICtStepRootObject :CoreHelper.IItem";
            InterfaceNameWithInheritanceStrings[ParameterType.SurivewStep] = "public interface ISurviewStepRootObject : ICtStepRootObject";
            InterfaceNameWithInheritanceStrings[ParameterType.RotatingStep] = "public interface IRotatingStepRootObject : ICtStepRootObject";
            InterfaceNameWithInheritanceStrings[ParameterType.AxialStep] = "public interface IAxialStepRootObject : IRotatingStepRootObject";
            InterfaceNameWithInheritanceStrings[ParameterType.HelicalStep] = "public interface IHelixStepRootObject : IRotatingStepRootObject";
            InterfaceNameWithInheritanceStrings[ParameterType.ResultGeneral] = "public interface IResultRootObject:CoreHelper.IItem";
            InterfaceNameWithInheritanceStrings[ParameterType.SurviewResult] = "public interface ISurviewResultRootObject : IResultRootObject";
            InterfaceNameWithInheritanceStrings[ParameterType.RotatingResult] = "public interface IRotatingResultRootObject : IResultRootObject";
            InterfaceNameWithInheritanceStrings[ParameterType.AxialResult] = "public interface IAxialResultRootObject : IRotatingResultRootObject";
            InterfaceNameWithInheritanceStrings[ParameterType.HelicalResult] = "public interface IHelixResultRootObject : IRotatingResultRootObject";

            ClassNameWithInheritanceStrings[ParameterType.CTStep] = "public abstract class CtStepRootObject : CoreHelper.Item, ICtStepRootObject";
            ClassNameWithInheritanceStrings[ParameterType.SurivewStep] = "public class SurviewStepRootObject: CtStepRootObject, ISurviewStepRootObject";
            ClassNameWithInheritanceStrings[ParameterType.RotatingStep] = "public abstract class RotatingStepRootObject : CtStepRootObject, IRotatingStepRootObject";
            ClassNameWithInheritanceStrings[ParameterType.AxialStep] = "public class AxialStepRootObject : RotatingStepRootObject, IAxialStepRootObject";
            ClassNameWithInheritanceStrings[ParameterType.HelicalStep] = "public class HelixStepRootObject : RotatingStepRootObject, IHelixStepRootObject";
            ClassNameWithInheritanceStrings[ParameterType.ResultGeneral] = "public abstract class ResultRootObject :CoreHelper.Item, IResultRootObject";
            ClassNameWithInheritanceStrings[ParameterType.SurviewResult] = "public class SurviewResultRootObject : ResultRootObject, ISurviewResultRootObject";
            ClassNameWithInheritanceStrings[ParameterType.RotatingResult] = "public abstract class RotatingResultRootObject : ResultRootObject, IRotatingResultRootObject";
            ClassNameWithInheritanceStrings[ParameterType.AxialResult] = "public class AxialResultRootObject : RotatingResultRootObject, IAxialResultRootObject";
            ClassNameWithInheritanceStrings[ParameterType.HelicalResult] = "public class HelixResultRootObject : RotatingResultRootObject, IHelixResultRootObject";

            CtorString[ParameterType.CTStep] = "protected CtStepRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.SurivewStep] = "public SurviewStepRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.RotatingStep] = "protected RotatingStepRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.AxialStep] = "public AxialStepRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.HelicalStep] = "public HelixStepRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.ResultGeneral] = "protected ResultRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.SurviewResult] = "public SurviewResultRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.RotatingResult] = "protected RotatingResultRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.AxialResult] = "public AxialResultRootObject(System.Guid id) : base(id) {}";
            CtorString[ParameterType.HelicalResult] = "public HelixResultRootObject(System.Guid id) : base(id) {}";

            ParameterFactoryMethodNameString[ParameterType.CTStep] = "public void SetCTStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.SurivewStep] = "public void SetSurviewStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.RotatingStep] = "public void SetRotatingStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.AxialStep] = "public void SetAxialStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.HelicalStep] = "public void SetHelicalStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.ResultGeneral] = "public void SetResultGeneralFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.SurviewResult] = "public void SetSurviewResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.RotatingResult] = "public void SetRotatingResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.AxialResult] = "public void SetAxialResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";
            ParameterFactoryMethodNameString[ParameterType.HelicalResult] = "public void SetHelicalResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)";


            RuleFactoryMethodNameString[Category.CTStep] = "public void AddCTStepRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)";
            RuleFactoryMethodNameString[Category.Surview] = "public void AddSurviewRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)";
            RuleFactoryMethodNameString[Category.RotatingStep] = "public void AddRotatingStepRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)";
            RuleFactoryMethodNameString[Category.Axial] = "public void AddAxialRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)";
            RuleFactoryMethodNameString[Category.Helix] = "public void AddHelixRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)";

            isInitialized = true;

        }

        public static string GetInterfaceName(ParameterType parameterType)
        {
            Initialize();
            return InterfaceNameWithInheritanceStrings[parameterType];
        }

        public static string GetClassName(ParameterType parameterType)
        {
            Initialize();
            return ClassNameWithInheritanceStrings[parameterType];
        }

        public static string GetParameterMethodName(ParameterType parameterType)
        {
            Initialize();
            return ParameterFactoryMethodNameString[parameterType];
        }

        public static string GetRuleMethodName(Category category)
        {
            Initialize();
            return RuleFactoryMethodNameString[category];
        }
    }
}
