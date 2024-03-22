namespace RootObject
{

	public interface ISurviewStepRootObject : ICtStepRootObject
	{

		Parameters.SurviewLength SurviewLength { get; }

	}

	public class SurviewStepRootObject: CtStepRootObject, ISurviewStepRootObject
	{

		public SurviewStepRootObject(System.Guid id) : base(id) {}

		public Parameters.SurviewLength SurviewLength => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SurviewLength] as Parameters.SurviewLength;

	}

}
