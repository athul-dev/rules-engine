namespace RootObject
{

	public interface IAxialResultRootObject : IRotatingResultRootObject
	{

		Parameters.ApexFeathering ApexFeathering { get; }

		Parameters.DisplayMode DisplayMode { get; }

		Parameters.ViewConvention ViewConvention { get; }

	}

	public class AxialResultRootObject : RotatingResultRootObject, IAxialResultRootObject
	{

		public AxialResultRootObject(System.Guid id) : base(id) {}

		public Parameters.ApexFeathering ApexFeathering => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ApexFeathering] as Parameters.ApexFeathering;

		public Parameters.DisplayMode DisplayMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.DisplayMode] as Parameters.DisplayMode;

		public Parameters.ViewConvention ViewConvention => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ViewConvention] as Parameters.ViewConvention;

	}

}
