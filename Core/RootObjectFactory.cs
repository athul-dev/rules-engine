using System;
using System.Collections.Generic;
using CoreHelper;
using ERGenerator;
using Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces;
using RootObject;


namespace Core
{
    public interface IRootObjectFactory
    {
        IList<IRootObject> GetRootObjects(string filePath);
    }
    public class RootObjectFactory:IRootObjectFactory
    {
        public IList<IRootObject> GetRootObjects(string filePath)
        {
            var rootObjects = new List<IRootObject>();

            var rulesDataModel = new DataModel(filePath);

            var factBuilder = new FactBuilderUtil();

            var rootObjectBuilderUtil = new RootObjectBuilderUtil();

            IRootObjectCreator resultRootObjectCreator = new RootObjectCreator();

            foreach (var stepListStep in rulesDataModel.ExamRecord.ExamRecordReadOnly.StepList.Steps)
            {
                if (stepListStep.Type == StepType.Pet || stepListStep.Type == StepType.Spect)
                {
                    continue;
                }
                rulesDataModel.SetCurrentStep(stepListStep.ID);
                var step = resultRootObjectCreator.GetStepRootObject(stepListStep.Type, stepListStep.ID, rootObjectBuilderUtil, rulesDataModel, factBuilder);
               
                foreach (var resultReadOnly in stepListStep.Results)
                {
                    rulesDataModel.SetCurrentResult(stepListStep.ID, resultReadOnly.ID);
                    var result = resultRootObjectCreator.GetResultRootObject(resultReadOnly.ParentStep.Type, resultReadOnly.ID, rootObjectBuilderUtil, rulesDataModel, factBuilder);
                    step.Children.Add(result);
                }

                var rootObject = new CoreHelper.RootObject(step, stepListStep.Type, rulesDataModel);

                rootObjects.Add(rootObject);
            }

            return rootObjects;
        }
    }

    interface IRootObjectCreator
    {
        IItem GetResultRootObject(StepType type, Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel ruleDataModel, IFactBuilderUtil factBuilderUtil);

        IItem GetStepRootObject(StepType type, Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel ruleDataModel, IFactBuilderUtil factBuilderUtil);
    }

    public class RootObjectCreator: IRootObjectCreator
    {
        
        public RootObjectCreator()
        {
            internalResultDictionary = new Dictionary<StepType, Func<Guid, RootObjectBuilderUtil, DataModel, IFactBuilderUtil, IItem>>();

            internalResultDictionary[StepType.Surview] = CreateSurviewResultObject;
            internalResultDictionary[StepType.Axial] = CreateAxialResultObject;
            internalResultDictionary[StepType.Helix] = CreateHelicalResultObject;

            internalStepDictionary = new Dictionary<StepType, Func<Guid, RootObjectBuilderUtil, DataModel, IFactBuilderUtil, IItem>>();

            internalStepDictionary[StepType.Surview] = CreateSurviewStepObject;
            internalStepDictionary[StepType.Axial] = CreateAxialStepObject;
            internalStepDictionary[StepType.Helix] = CreateHelicalStepObject;

        }

        public IItem GetResultRootObject(StepType type, Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel ruleDataModel, IFactBuilderUtil factBuilderUtil)
        {
            if (!internalResultDictionary.ContainsKey(type))
            {
                return null;
            }

            var result = internalResultDictionary[type].Invoke(id, rootObjectBuilderUtil, ruleDataModel, factBuilderUtil);

            return result;
        }

        public IItem GetStepRootObject(StepType type, Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel ruleDataModel, IFactBuilderUtil factBuilderUtil)
        {
            if (!internalStepDictionary.ContainsKey(type))
            {
                return null;
            }

            var step = internalStepDictionary[type].Invoke(id, rootObjectBuilderUtil, ruleDataModel, factBuilderUtil);

            return step;
        }


        private ISurviewResultRootObject CreateSurviewResultObject(Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel rulesDataModel, IFactBuilderUtil factBuilder)
        {
            var result = new SurviewResultRootObject(id);
            rootObjectBuilderUtil.SetResultGeneralFacts(result, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetSurviewResultFacts(result, rulesDataModel, factBuilder);
            return result;
        }

        private IAxialResultRootObject CreateAxialResultObject(Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel rulesDataModel, IFactBuilderUtil factBuilder)
        {
            var result = new AxialResultRootObject(id);
            rootObjectBuilderUtil.SetResultGeneralFacts(result, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetRotatingResultFacts(result, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetAxialResultFacts(result, rulesDataModel, factBuilder);
            return result;
        }

        private IHelixResultRootObject CreateHelicalResultObject(Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel rulesDataModel, IFactBuilderUtil factBuilder)
        {
            var result = new HelixResultRootObject(id);
            rootObjectBuilderUtil.SetResultGeneralFacts(result, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetRotatingResultFacts(result, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetHelicalResultFacts(result, rulesDataModel, factBuilder);
            return result;
        }

        private ISurviewStepRootObject CreateSurviewStepObject(Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel rulesDataModel, IFactBuilderUtil factBuilder)
        {
            var step = new SurviewStepRootObject(id);
            rootObjectBuilderUtil.SetCTStepFacts(step, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetSurviewStepFacts(step, rulesDataModel, factBuilder);
            return step;
        }

        private IAxialStepRootObject CreateAxialStepObject(Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel rulesDataModel, IFactBuilderUtil factBuilder)
        {
            var step = new AxialStepRootObject(id);
            rootObjectBuilderUtil.SetCTStepFacts(step, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetRotatingStepFacts(step, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetAxialStepFacts(step, rulesDataModel, factBuilder);
            return step;
        }

        private IHelixStepRootObject CreateHelicalStepObject(Guid id, RootObjectBuilderUtil rootObjectBuilderUtil, DataModel rulesDataModel, IFactBuilderUtil factBuilder)
        {
            var step = new HelixStepRootObject(id);
            rootObjectBuilderUtil.SetCTStepFacts(step, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetRotatingStepFacts(step, rulesDataModel, factBuilder);
            rootObjectBuilderUtil.SetHelicalStepFacts(step, rulesDataModel, factBuilder);
            return step;
        }

        private readonly Dictionary<StepType, Func<Guid, RootObjectBuilderUtil, DataModel, IFactBuilderUtil, IItem>> internalResultDictionary;

        private readonly Dictionary<StepType, Func<Guid, RootObjectBuilderUtil, DataModel, IFactBuilderUtil, IItem>> internalStepDictionary;
    }

    


}
