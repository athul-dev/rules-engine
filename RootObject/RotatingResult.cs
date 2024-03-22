namespace RootObject
{

	public interface IRotatingResultRootObject : IResultRootObject
	{

		Parameters.AdaptiveFilter AdaptiveFilter { get; }

		Parameters.AdaptiveFilterCardiacMode AdaptiveFilterCardiacMode { get; }

		Parameters.ConeBeam ConeBeam { get; }

		Parameters.Cosmix Cosmix { get; }

		Parameters.CrosstalkCorrection CrosstalkCorrection { get; }

		Parameters.DetectorDisplacementCorrection DetectorDisplacementCorrection { get; }

		Parameters.EcgPhaseDelay EcgPhaseDelay { get; }

		Parameters.EcgPhaseType EcgPhaseType { get; }

		Parameters.Filter Filter { get; }

		Parameters.FilterUI FilterUI { get; }

		Parameters.iDose iDose { get; }

		Parameters.iDoseDynamicMaxLevel iDoseDynamicMaxLevel { get; }

		Parameters.iDoseLevel iDoseLevel { get; }

		Parameters.iDoseMedianNoise iDoseMedianNoise { get; }

		Parameters.iDoseMultiResolution iDoseMultiResolution { get; }

		Parameters.iDoseUserLevel iDoseUserLevel { get; }

		Parameters.IMR IMR { get; }

		Parameters.Jog Jog { get; }

		Parameters.MetalCorrection MetalCorrection { get; }

		Parameters.MetalProtection MetalProtection { get; }

		Parameters.NSlices NSlices { get; }

		Parameters.OffFocal OffFocal { get; }

		Parameters.OptsIrsAddNoise OptsIrsAddNoise { get; }

		Parameters.PreciseImage PreciseImage { get; }

		Parameters.PreciseImageDefinition PreciseImageDefinition { get; }

		Parameters.PulmoPhaseDelay PulmoPhaseDelay { get; }

		Parameters.ReconAngle ReconAngle { get; }

		Parameters.ReconBinning ReconBinning { get; }

		Parameters.ReconEndPosition ReconEndPosition { get; }

		Parameters.ReconFieldOfView ReconFieldOfView { get; }

		Parameters.ReconIncrement ReconIncrement { get; }

		Parameters.ReconMaxEffFOV ReconMaxEffFOV { get; }

		Parameters.UltraImage UltraImage { get; }

		Parameters.UltraImageThreshold UltraImageThreshold { get; }

		Parameters.Warp Warp { get; }

	}

	public abstract class RotatingResultRootObject : ResultRootObject, IRotatingResultRootObject
	{

		protected RotatingResultRootObject(System.Guid id) : base(id) {}

		public Parameters.AdaptiveFilter AdaptiveFilter => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.AdaptiveFilter] as Parameters.AdaptiveFilter;

		public Parameters.AdaptiveFilterCardiacMode AdaptiveFilterCardiacMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.AdaptiveFilterCardiacMode] as Parameters.AdaptiveFilterCardiacMode;

		public Parameters.ConeBeam ConeBeam => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ConeBeam] as Parameters.ConeBeam;

		public Parameters.Cosmix Cosmix => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Cosmix] as Parameters.Cosmix;

		public Parameters.CrosstalkCorrection CrosstalkCorrection => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CrosstalkCorrection] as Parameters.CrosstalkCorrection;

		public Parameters.DetectorDisplacementCorrection DetectorDisplacementCorrection => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.DetectorDisplacementCorrection] as Parameters.DetectorDisplacementCorrection;

		public Parameters.EcgPhaseDelay EcgPhaseDelay => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.EcgPhaseDelay] as Parameters.EcgPhaseDelay;

		public Parameters.EcgPhaseType EcgPhaseType => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.EcgPhaseType] as Parameters.EcgPhaseType;

		public Parameters.Filter Filter => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Filter] as Parameters.Filter;

		public Parameters.FilterUI FilterUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.FilterUI] as Parameters.FilterUI;

		public Parameters.iDose iDose => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDose] as Parameters.iDose;

		public Parameters.iDoseDynamicMaxLevel iDoseDynamicMaxLevel => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseDynamicMaxLevel] as Parameters.iDoseDynamicMaxLevel;

		public Parameters.iDoseLevel iDoseLevel => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseLevel] as Parameters.iDoseLevel;

		public Parameters.iDoseMedianNoise iDoseMedianNoise => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseMedianNoise] as Parameters.iDoseMedianNoise;

		public Parameters.iDoseMultiResolution iDoseMultiResolution => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseMultiResolution] as Parameters.iDoseMultiResolution;

		public Parameters.iDoseUserLevel iDoseUserLevel => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseUserLevel] as Parameters.iDoseUserLevel;

		public Parameters.IMR IMR => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IMR] as Parameters.IMR;

		public Parameters.Jog Jog => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Jog] as Parameters.Jog;

		public Parameters.MetalCorrection MetalCorrection => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.MetalCorrection] as Parameters.MetalCorrection;

		public Parameters.MetalProtection MetalProtection => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.MetalProtection] as Parameters.MetalProtection;

		public Parameters.NSlices NSlices => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.NSlices] as Parameters.NSlices;

		public Parameters.OffFocal OffFocal => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.OffFocal] as Parameters.OffFocal;

		public Parameters.OptsIrsAddNoise OptsIrsAddNoise => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.OptsIrsAddNoise] as Parameters.OptsIrsAddNoise;

		public Parameters.PreciseImage PreciseImage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PreciseImage] as Parameters.PreciseImage;

		public Parameters.PreciseImageDefinition PreciseImageDefinition => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PreciseImageDefinition] as Parameters.PreciseImageDefinition;

		public Parameters.PulmoPhaseDelay PulmoPhaseDelay => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PulmoPhaseDelay] as Parameters.PulmoPhaseDelay;

		public Parameters.ReconAngle ReconAngle => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconAngle] as Parameters.ReconAngle;

		public Parameters.ReconBinning ReconBinning => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconBinning] as Parameters.ReconBinning;

		public Parameters.ReconEndPosition ReconEndPosition => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconEndPosition] as Parameters.ReconEndPosition;

		public Parameters.ReconFieldOfView ReconFieldOfView => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconFieldOfView] as Parameters.ReconFieldOfView;

		public Parameters.ReconIncrement ReconIncrement => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconIncrement] as Parameters.ReconIncrement;

		public Parameters.ReconMaxEffFOV ReconMaxEffFOV => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconMaxEffFOV] as Parameters.ReconMaxEffFOV;

		public Parameters.UltraImage UltraImage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.UltraImage] as Parameters.UltraImage;

		public Parameters.UltraImageThreshold UltraImageThreshold => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.UltraImageThreshold] as Parameters.UltraImageThreshold;

		public Parameters.Warp Warp => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Warp] as Parameters.Warp;

	}

}
