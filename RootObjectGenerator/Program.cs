using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using CoreHelper;

namespace RootObjectGenerator
{
    class Program
    {
        private static string assemblyName = @"C:\Pms\System\Parameters.dll";

        private static readonly string workingDirectory = Environment.CurrentDirectory;

        private static readonly string projectDirectory = Directory.GetParent(workingDirectory)?.Parent?.FullName + "\\RootObject\\";


        static void Main()
        { 
            Assembly assembly = Assembly.LoadFrom(assemblyName);

            Dictionary<ParameterType, List<ParameterAttribute>> parameterDictionary = new Dictionary<ParameterType, List<ParameterAttribute>>();

            Dictionary<Category, List<RuleAttribute>> ruleDictionary = new Dictionary<Category, List<RuleAttribute>>();

            var classes = assembly.GetTypes();
            foreach (var cls in classes)
            {
                //var attribute = cls.CustomAttributes.First;
                var attributes = cls.GetCustomAttributes(typeof(ParameterAttribute), false);
                if (attributes.Length > 0)
                {
                    if (attributes[0] is ParameterAttribute parameterAttribute)
                    {
                        if (!parameterDictionary.ContainsKey(parameterAttribute.ParameterType))
                        {
                            parameterDictionary[parameterAttribute.ParameterType] = new List<ParameterAttribute>();
                        }

                        parameterDictionary[parameterAttribute.ParameterType].Add(parameterAttribute);
                        continue;
                    }
                }

                attributes = cls.GetCustomAttributes(typeof(RuleAttribute), false);
                if (attributes.Length > 0)
                {
                    var ruleAttribute = attributes[0] as RuleAttribute;
                    if (ruleAttribute != null)
                    {
                        if (!ruleDictionary.ContainsKey(ruleAttribute.Category))
                        {
                            ruleDictionary[ruleAttribute.Category] = new List<RuleAttribute>();
                        }

                        ruleDictionary[ruleAttribute.Category].Add(ruleAttribute);
                    }
                }
            }

            RootObjectHelper.Initialize();
            var allFiles = RootObjectHelper.InterfaceNameWithInheritanceStrings.Keys;
            Console.WriteLine("Generate Root Object Files");
            foreach (var item in allFiles)
            {
                if(!parameterDictionary.ContainsKey(item))
                {
                    parameterDictionary[item] = new List<ParameterAttribute>();
                }

                CreateRootObject(item, parameterDictionary[item]);

                Console.WriteLine("Created Class :" + item);
            }

            Console.WriteLine("Generate Root Object Factory Util");
            CreateRootObjectFactory(parameterDictionary);

            Console.WriteLine("Generate Rules Factory Util");
            CreateRulesFactory(ruleDictionary);

            //Console.ReadKey();
        }

        

        public static void CreateRootObject(ParameterType parameterType, IList<ParameterAttribute> parameterAttributes)
        {
            var filePath = projectDirectory + parameterType.ToString() +".cs";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }


            List<string> text = new List<string>();

            text.Add("namespace RootObject");
            text.Add("{");
            text.Add("");
            AddInterface(text, parameterType, parameterAttributes);
            AddClass(text, parameterType, parameterAttributes);
            text.Add("}");
            File.AppendAllLines(filePath, text);
        }       

        public static void AddInterface(List<string> text, ParameterType parameterType, IList<ParameterAttribute> parameterAttributes)
        {
            text.Add("\t" +RootObjectHelper.GetInterfaceName(parameterType));
            text.Add("\t" + "{");
            text.Add("");
            foreach (ParameterAttribute parameter in parameterAttributes)
            {
                text.Add("\t" + "\t" + "Parameters."+parameter.ParameterName + " " + parameter.ParameterName + " { get; }");
                text.Add("");
            }

            text.Add("\t" + "}");
            text.Add("");

        }

        public static void AddClass(List<string> text, ParameterType parameterType, IList<ParameterAttribute> parameterAttributes)
        {
            text.Add("\t" + RootObjectHelper.GetClassName(parameterType));
            text.Add("\t" + "{");
            text.Add("");
            text.Add("\t" + "\t" + RootObjectHelper.CtorString[parameterType]);
            text.Add("");
           
            foreach (ParameterAttribute parameter in parameterAttributes)
            {
                if (parameter.ErType == ERType.Step)
                {
                    text.Add("\t" + "\t" + $"public Parameters.{parameter.ParameterName} {parameter.ParameterName} => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.{parameter.ParameterName}] as Parameters.{parameter.ParameterName};");
                }
                else if (parameter.ErType == ERType.Recon)
                {
                    text.Add("\t" + "\t" + $"public Parameters.{parameter.ParameterName} {parameter.ParameterName} => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.{parameter.ParameterName}] as Parameters.{parameter.ParameterName};");
                }
                else if (parameter.ErType == ERType.Result)
                {
                    text.Add("\t" + "\t" + $"public Parameters.{parameter.ParameterName} {parameter.ParameterName} => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.{parameter.ParameterName}] as Parameters.{parameter.ParameterName};");
                }
                else
                {
                    text.Add("\t" + "\t" + $"public Parameters.{parameter.ParameterName} {parameter.ParameterName} => FactCollection[CoreHelper.InternalParameters.{parameter.ParameterName}] as Parameters.{parameter.ParameterName};");
                }
                text.Add("");
            }
            
            text.Add("\t" + "}");
            text.Add("");
        }

        public static void CreateRootObjectFactory(Dictionary<ParameterType, List<ParameterAttribute>> dictionary)
        {
            var filePath = projectDirectory + "RootObjectBuilderUtil.cs";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            List<string> text = new List<string>();

            text.Add("namespace RootObject");
            text.Add("{");
            text.Add("");
            text.Add("\t" + "public class RootObjectBuilderUtil");
            text.Add("\t" + "{");
            text.Add("");
            var allMethods = RootObjectHelper.ParameterFactoryMethodNameString.Keys;

            foreach (var method in allMethods)
            {
                if(!dictionary.ContainsKey(method))
                {
                    dictionary[method] = new List<ParameterAttribute>();
                }

                AddFactoryMethod(text, method, dictionary[method]);
                Console.WriteLine("Added factory method for " + method);
            }

            text.Add("\t" + "}");
            text.Add("}");

            File.AppendAllLines(filePath, text);
        }

        public static void AddFactoryMethod(List<string> text, ParameterType parameterType, IList<ParameterAttribute> parameterAttributes)
        {
            text.Add("\t" + "\t" + RootObjectHelper.GetParameterMethodName(parameterType));
            text.Add("\t" + "\t"+ "{");
            text.Add("");
            foreach (var parameter in parameterAttributes)
            {
                if (parameter.ErType == ERType.Step)
                {
                    text.Add("\t" + "\t" + "\t" + $"rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.{parameter.ParameterName}] = factBuilderUtil.GetFact<{parameter.ParameterDataType.FullName}, Parameters.{parameter.ParameterName}>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.{parameter.ParameterName});");
                }
                else if (parameter.ErType == ERType.Recon)
                {
                    text.Add("\t" + "\t" + "\t" + $"rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.{parameter.ParameterName}] = factBuilderUtil.GetFact<{parameter.ParameterDataType.FullName}, Parameters.{parameter.ParameterName}>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.{parameter.ParameterName});");
                }
                else if (parameter.ErType == ERType.Result)
                {
                    text.Add("\t" + "\t" + "\t" + $"rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.{parameter.ParameterName}] = factBuilderUtil.GetFact<{parameter.ParameterDataType.FullName}, Parameters.{parameter.ParameterName}>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.{parameter.ParameterName});");
                }
                else
                {
                    text.Add("\t" + "\t" + "\t" + $"rootObject[CoreHelper.InternalParameters.{parameter.ParameterName}] = factBuilderUtil.GetEmptyFact<{parameter.ParameterDataType.FullName}, Parameters.{parameter.ParameterName}>();"); 
                }
                text.Add("");
            }
            text.Add("\t" + "\t" + "}");
            text.Add("");
        }

        public static void CreateRulesFactory(Dictionary<Category, List<RuleAttribute>> dictionary)
        {
            var filePath = projectDirectory + "RulesBuilderUtil.cs";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            List<string> text = new List<string>();

            text.Add("using System.Collections.Generic;");
            text.Add("using CoreHelper;");
            text.Add("using Parameters;");
            text.Add("");
            text.Add("namespace RootObject");
            text.Add("{");
            text.Add("");
            text.Add("\t" + "public class RulesBuilderUtil");
            text.Add("\t" + "{");
            text.Add("");
            var allMethods = RootObjectHelper.RuleFactoryMethodNameString.Keys;

            foreach (var method in allMethods)
            {
                if (!dictionary.ContainsKey(method))
                {
                    dictionary[method] = new List<RuleAttribute>();
                }

                AddRuleFactoryMethod(text, method, dictionary[method]);
                Console.WriteLine("Added factory method for " + method);
            }

            text.Add("\t" + "}");
            text.Add("}");

            File.AppendAllLines(filePath, text);
        }

        public static void AddRuleFactoryMethod(List<string> text, Category category, IList<RuleAttribute> ruleAttributes)
        {
            text.Add("\t" + "\t" + RootObjectHelper.GetRuleMethodName(category));
            text.Add("\t" + "\t" + "{");
            text.Add("");
            foreach (var ruleAttribute in ruleAttributes)
            {
                text.Add("\t" + "\t" + "\t" + $"ruleInfoDictionary[\"{ruleAttribute.RuleName}\"] = new RuleInfo(\"{ruleAttribute.RuleName}\", {ruleAttribute.Priority}, Category.{ruleAttribute.Category}, new {ruleAttribute.RuleName}(), {ruleAttribute.IsLocalField.ToString().ToLower()});");
                text.Add("");
            }
            text.Add("\t" + "\t" + "}");
            text.Add("");
        }
    }
}
