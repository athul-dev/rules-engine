using System;
using System.Collections.Generic;
using System.Linq;
using ERGenerator;
using Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces;

namespace CoreHelper
{
    public interface IRootObject
    {
        StepType Type { get; }

        IItem Step { get; }

        Guid CurrentStepId { get; }

        Guid CurrentResultId { get; }

        IDictionary<string, IFieldFact> FactCollection { get; }

        IFieldFact this[string key] { get; }

        T GetFact<T>(string parameterName) where T : class, IFact;
    }

    public interface IRootObjectInternal : IRootObject
    {
        void UpdatedCurrentResultId(Guid id);

        IExamRecordUpdater ExamRecordUpdater { get; }
    }

    public class RootObject : IRootObjectInternal
    {
        public RootObject(IItem step, StepType type, IExamRecordUpdater examRecordUpdater)
        {
            if (step == null || step.Children.Count == 0)
            {
                throw new ArgumentException("Step is invalid, Root object cannot be created");
            }

            Step = step;
            CurrentResultId = Step.Children.First().Id;
            Type = type;
            ExamRecordUpdater = examRecordUpdater;
        }

        public StepType Type { get; }

        public IExamRecordUpdater ExamRecordUpdater { get; }

        public IItem Step { get; }

        public Guid CurrentStepId => Step.Id;

        public Guid CurrentResultId { get; set; }

        public IDictionary<string, IFieldFact> FactCollection => Step.GetFacts(CurrentResultId);

        public IFieldFact this[string key]
        {
            get => GetFact<IFieldFact>(key);
        }

        public T GetFact<T>(string parameterName) where T : class, IFact
        {
            return Step.GetFact<T>(parameterName, CurrentResultId);
        }

        public void UpdatedCurrentResultId(Guid id)
        {
            CurrentResultId = id;
        }
    }
}
