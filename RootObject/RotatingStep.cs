namespace RootObject
{

	public interface IRotatingStepRootObject : ICtStepRootObject
	{

		Parameters.AbsoluteMaxmAsPerSlice AbsoluteMaxmAsPerSlice { get; }

		Parameters.AbsoluteMinmAsPerSlice AbsoluteMinmAsPerSlice { get; }

		Parameters.ACS ACS { get; }

		Parameters.ActualNoiseLevel ActualNoiseLevel { get; }

		Parameters.AngularSampling AngularSampling { get; }

		Parameters.BedSpeed BedSpeed { get; }

		Parameters.BolusDelta BolusDelta { get; }

		Parameters.BolusThreasholMode BolusThreasholMode { get; }

		Parameters.BolusThreshold BolusThreshold { get; }

		Parameters.Breathrate Breathrate { get; }

		Parameters.ClinicalApplication ClinicalApplication { get; }

		Parameters.Ecg Ecg { get; }

		Parameters.EcgDoseIrregularities EcgDoseIrregularities { get; }

		Parameters.EcgPhaseTolerance EcgPhaseTolerance { get; }

		Parameters.Evolving Evolving { get; }

		Parameters.FDom FDom { get; }

		Parameters.Heartbeat Heartbeat { get; }

		Parameters.JogNumberOfJogs JogNumberOfJogs { get; }

		Parameters.NoiseLevel NoiseLevel { get; }

		Parameters.Organ Organ { get; }

		Parameters.OrganUI OrganUI { get; }

		Parameters.Pulmo Pulmo { get; }

		Parameters.PulmoByVarian PulmoByVarian { get; }

		Parameters.QuarterDetOffset QuarterDetOffset { get; }

		Parameters.ReferenceBodySize ReferenceBodySize { get; }

		Parameters.ReferencePatientSize ReferencePatientSize { get; }

		Parameters.RotationTime RotationTime { get; }

		Parameters.RotationTimeUI RotationTimeUI { get; }

		Parameters.SampledCollimation SampledCollimation { get; }

		Parameters.ScanConeBeam ScanConeBeam { get; }

		Parameters.ScanMaxEffFOV ScanMaxEffFOV { get; }

		Parameters.SeriesLength SeriesLength { get; }

		Parameters.SizeSpecificDose SizeSpecificDose { get; }

		Parameters.Tilt Tilt { get; }

		Parameters.ZDom ZDom { get; }

	}

	public abstract class RotatingStepRootObject : CtStepRootObject, IRotatingStepRootObject
	{

		protected RotatingStepRootObject(System.Guid id) : base(id) {}

		public Parameters.AbsoluteMaxmAsPerSlice AbsoluteMaxmAsPerSlice => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AbsoluteMaxmAsPerSlice] as Parameters.AbsoluteMaxmAsPerSlice;

		public Parameters.AbsoluteMinmAsPerSlice AbsoluteMinmAsPerSlice => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AbsoluteMinmAsPerSlice] as Parameters.AbsoluteMinmAsPerSlice;

		public Parameters.ACS ACS => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ACS] as Parameters.ACS;

		public Parameters.ActualNoiseLevel ActualNoiseLevel => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ActualNoiseLevel] as Parameters.ActualNoiseLevel;

		public Parameters.AngularSampling AngularSampling => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AngularSampling] as Parameters.AngularSampling;

		public Parameters.BedSpeed BedSpeed => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BedSpeed] as Parameters.BedSpeed;

		public Parameters.BolusDelta BolusDelta => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusDelta] as Parameters.BolusDelta;

		public Parameters.BolusThreasholMode BolusThreasholMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusThreasholMode] as Parameters.BolusThreasholMode;

		public Parameters.BolusThreshold BolusThreshold => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusThreshold] as Parameters.BolusThreshold;

		public Parameters.Breathrate Breathrate => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Breathrate] as Parameters.Breathrate;

		public Parameters.ClinicalApplication ClinicalApplication => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ClinicalApplication] as Parameters.ClinicalApplication;

		public Parameters.Ecg Ecg => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Ecg] as Parameters.Ecg;

		public Parameters.EcgDoseIrregularities EcgDoseIrregularities => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgDoseIrregularities] as Parameters.EcgDoseIrregularities;

		public Parameters.EcgPhaseTolerance EcgPhaseTolerance => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgPhaseTolerance] as Parameters.EcgPhaseTolerance;

		public Parameters.Evolving Evolving => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Evolving] as Parameters.Evolving;

		public Parameters.FDom FDom => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FDom] as Parameters.FDom;

		public Parameters.Heartbeat Heartbeat => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Heartbeat] as Parameters.Heartbeat;

		public Parameters.JogNumberOfJogs JogNumberOfJogs => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.JogNumberOfJogs] as Parameters.JogNumberOfJogs;

		public Parameters.NoiseLevel NoiseLevel => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseLevel] as Parameters.NoiseLevel;

		public Parameters.Organ Organ => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Organ] as Parameters.Organ;

		public Parameters.OrganUI OrganUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.OrganUI] as Parameters.OrganUI;

		public Parameters.Pulmo Pulmo => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pulmo] as Parameters.Pulmo;

		public Parameters.PulmoByVarian PulmoByVarian => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PulmoByVarian] as Parameters.PulmoByVarian;

		public Parameters.QuarterDetOffset QuarterDetOffset => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.QuarterDetOffset] as Parameters.QuarterDetOffset;

		public Parameters.ReferenceBodySize ReferenceBodySize => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ReferenceBodySize] as Parameters.ReferenceBodySize;

		public Parameters.ReferencePatientSize ReferencePatientSize => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ReferencePatientSize] as Parameters.ReferencePatientSize;

		public Parameters.RotationTime RotationTime => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationTime] as Parameters.RotationTime;

		public Parameters.RotationTimeUI RotationTimeUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationTimeUI] as Parameters.RotationTimeUI;

		public Parameters.SampledCollimation SampledCollimation => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SampledCollimation] as Parameters.SampledCollimation;

		public Parameters.ScanConeBeam ScanConeBeam => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanConeBeam] as Parameters.ScanConeBeam;

		public Parameters.ScanMaxEffFOV ScanMaxEffFOV => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanMaxEffFOV] as Parameters.ScanMaxEffFOV;

		public Parameters.SeriesLength SeriesLength => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SeriesLength] as Parameters.SeriesLength;

		public Parameters.SizeSpecificDose SizeSpecificDose => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SizeSpecificDose] as Parameters.SizeSpecificDose;

		public Parameters.Tilt Tilt => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Tilt] as Parameters.Tilt;

		public Parameters.ZDom ZDom => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ZDom] as Parameters.ZDom;

	}

}
