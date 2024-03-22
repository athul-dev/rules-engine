namespace RootObject
{

	public interface IHelixStepRootObject : IRotatingStepRootObject
	{

		Parameters.AutoConeBeam AutoConeBeam { get; }

		Parameters.AutoPitchAndRT AutoPitchAndRT { get; }

		Parameters.ConeBeamPitchOffset ConeBeamPitchOffset { get; }

		Parameters.EcgDoseModulation EcgDoseModulation { get; }

		Parameters.EcgModulatedDose EcgModulatedDose { get; }

		Parameters.Hds Hds { get; }

		Parameters.HdsLagMicron HdsLagMicron { get; }

		Parameters.HdsLeadMicron HdsLeadMicron { get; }

		Parameters.MAsForPitchRT MAsForPitchRT { get; }

		Parameters.MAsPerSlice MAsPerSlice { get; }

		Parameters.MaxmAsPerSlice MaxmAsPerSlice { get; }

		Parameters.MinmAsPerSlice MinmAsPerSlice { get; }

		Parameters.ModulationLevel ModulationLevel { get; }

		Parameters.NoiseIndexHeadDelta NoiseIndexHeadDelta { get; }

		Parameters.NoiseIndexLiverDelta NoiseIndexLiverDelta { get; }

		Parameters.Pitch Pitch { get; }

		Parameters.PulmoTrigger PulmoTrigger { get; }

		Parameters.RequestedMaxmAsPerSlice RequestedMaxmAsPerSlice { get; }

		Parameters.RequestedMinmAsPerSlice RequestedMinmAsPerSlice { get; }

		Parameters.ScanLength ScanLength { get; }

		Parameters.SwiftMode SwiftMode { get; }

	}

	public class HelixStepRootObject : RotatingStepRootObject, IHelixStepRootObject
	{

		public HelixStepRootObject(System.Guid id) : base(id) {}

		public Parameters.AutoConeBeam AutoConeBeam => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AutoConeBeam] as Parameters.AutoConeBeam;

		public Parameters.AutoPitchAndRT AutoPitchAndRT => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AutoPitchAndRT] as Parameters.AutoPitchAndRT;

		public Parameters.ConeBeamPitchOffset ConeBeamPitchOffset => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ConeBeamPitchOffset] as Parameters.ConeBeamPitchOffset;

		public Parameters.EcgDoseModulation EcgDoseModulation => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgDoseModulation] as Parameters.EcgDoseModulation;

		public Parameters.EcgModulatedDose EcgModulatedDose => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgModulatedDose] as Parameters.EcgModulatedDose;

		public Parameters.Hds Hds => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Hds] as Parameters.Hds;

		public Parameters.HdsLagMicron HdsLagMicron => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HdsLagMicron] as Parameters.HdsLagMicron;

		public Parameters.HdsLeadMicron HdsLeadMicron => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HdsLeadMicron] as Parameters.HdsLeadMicron;

		public Parameters.MAsForPitchRT MAsForPitchRT => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAsForPitchRT] as Parameters.MAsForPitchRT;

		public Parameters.MAsPerSlice MAsPerSlice => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAsPerSlice] as Parameters.MAsPerSlice;

		public Parameters.MaxmAsPerSlice MaxmAsPerSlice => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MaxmAsPerSlice] as Parameters.MaxmAsPerSlice;

		public Parameters.MinmAsPerSlice MinmAsPerSlice => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MinmAsPerSlice] as Parameters.MinmAsPerSlice;

		public Parameters.ModulationLevel ModulationLevel => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ModulationLevel] as Parameters.ModulationLevel;

		public Parameters.NoiseIndexHeadDelta NoiseIndexHeadDelta => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseIndexHeadDelta] as Parameters.NoiseIndexHeadDelta;

		public Parameters.NoiseIndexLiverDelta NoiseIndexLiverDelta => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseIndexLiverDelta] as Parameters.NoiseIndexLiverDelta;

		public Parameters.Pitch Pitch => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pitch] as Parameters.Pitch;

		public Parameters.PulmoTrigger PulmoTrigger => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PulmoTrigger] as Parameters.PulmoTrigger;

		public Parameters.RequestedMaxmAsPerSlice RequestedMaxmAsPerSlice => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedMaxmAsPerSlice] as Parameters.RequestedMaxmAsPerSlice;

		public Parameters.RequestedMinmAsPerSlice RequestedMinmAsPerSlice => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedMinmAsPerSlice] as Parameters.RequestedMinmAsPerSlice;

		public Parameters.ScanLength ScanLength => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanLength] as Parameters.ScanLength;

		public Parameters.SwiftMode SwiftMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SwiftMode] as Parameters.SwiftMode;

	}

}
