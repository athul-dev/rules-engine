namespace RootObject
{

	public interface ICtStepRootObject :CoreHelper.IItem
	{

		Parameters.AcqSim AcqSim { get; }

		Parameters.ChildAdult ChildAdult { get; }

		Parameters.Collimation Collimation { get; }

		Parameters.ContrastBolusAgent ContrastBolusAgent { get; }

		Parameters.Current Current { get; }

		Parameters.Diameter Diameter { get; }

		Parameters.DirectionUI DirectionUI { get; }

		Parameters.Dlp Dlp { get; }

		Parameters.DlpUI DlpUI { get; }

		Parameters.DlpUpperLimit DlpUpperLimit { get; }

		Parameters.EndPosition EndPosition { get; }

		Parameters.FirstImagePosition FirstImagePosition { get; }

		Parameters.FocalSpotType FocalSpotType { get; }

		Parameters.FocusDiameter FocusDiameter { get; }

		Parameters.HeadBody HeadBody { get; }

		Parameters.Injection Injection { get; }

		Parameters.LocalAcsMas LocalAcsMas { get; }

		Parameters.LocalConeBeamMaxPitch LocalConeBeamMaxPitch { get; }

		Parameters.LocalCurrentEffFov LocalCurrentEffFov { get; }

		Parameters.LocalDlpFactor LocalDlpFactor { get; }

		Parameters.LocalDoseDlpMultiplier LocalDoseDlpMultiplier { get; }

		Parameters.LocalizerAutoOff LocalizerAutoOff { get; }

		Parameters.LocalManualPitch LocalManualPitch { get; }

		Parameters.LocalMinCycleTime LocalMinCycleTime { get; }

		Parameters.LocalPitchAndRt LocalPitchAndRt { get; }

		Parameters.LocalPreciseDoseNoMas LocalPreciseDoseNoMas { get; }

		Parameters.LocalRelativeDose LocalRelativeDose { get; }

		Parameters.LocalWindowCenterRange LocalWindowCenterRange { get; }

		Parameters.NumberOfScans NumberOfScans { get; }

		Parameters.PreciseDose PreciseDose { get; }

		Parameters.PreviewCenterXmm PreviewCenterXmm { get; }

		Parameters.PreviewCenterYmm PreviewCenterYmm { get; }

		Parameters.PreviewFieldOfView PreviewFieldOfView { get; }

		Parameters.RadiationDose RadiationDose { get; }

		Parameters.RadiationDoseUI RadiationDoseUI { get; }

		Parameters.RadiationDoseUpperLimit RadiationDoseUpperLimit { get; }

		Parameters.RequestedScanTime RequestedScanTime { get; }

		Parameters.Resolution Resolution { get; }

		Parameters.ResolutionUI ResolutionUI { get; }

		Parameters.RespiratoryDirection RespiratoryDirection { get; }

		Parameters.RespiratoryLevel RespiratoryLevel { get; }

		Parameters.RespiratoryMode RespiratoryMode { get; }

		Parameters.ScanTime ScanTime { get; }

		Parameters.ScanTimeUI ScanTimeUI { get; }

		Parameters.SliceMode SliceMode { get; }

		Parameters.ThicknessUI ThicknessUI { get; }

		Parameters.Trigger Trigger { get; }

		Parameters.Voltage Voltage { get; }

		Parameters.WedgeType WedgeType { get; }

		Parameters.XrayFilter XrayFilter { get; }

	}

	public abstract class CtStepRootObject : CoreHelper.Item, ICtStepRootObject
	{

		protected CtStepRootObject(System.Guid id) : base(id) {}

		public Parameters.AcqSim AcqSim => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AcqSim] as Parameters.AcqSim;

		public Parameters.ChildAdult ChildAdult => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ChildAdult] as Parameters.ChildAdult;

		public Parameters.Collimation Collimation => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Collimation] as Parameters.Collimation;

		public Parameters.ContrastBolusAgent ContrastBolusAgent => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ContrastBolusAgent] as Parameters.ContrastBolusAgent;

		public Parameters.Current Current => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Current] as Parameters.Current;

		public Parameters.Diameter Diameter => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Diameter] as Parameters.Diameter;

		public Parameters.DirectionUI DirectionUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DirectionUI] as Parameters.DirectionUI;

		public Parameters.Dlp Dlp => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Dlp] as Parameters.Dlp;

		public Parameters.DlpUI DlpUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DlpUI] as Parameters.DlpUI;

		public Parameters.DlpUpperLimit DlpUpperLimit => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DlpUpperLimit] as Parameters.DlpUpperLimit;

		public Parameters.EndPosition EndPosition => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EndPosition] as Parameters.EndPosition;

		public Parameters.FirstImagePosition FirstImagePosition => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FirstImagePosition] as Parameters.FirstImagePosition;

		public Parameters.FocalSpotType FocalSpotType => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FocalSpotType] as Parameters.FocalSpotType;

		public Parameters.FocusDiameter FocusDiameter => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FocusDiameter] as Parameters.FocusDiameter;

		public Parameters.HeadBody HeadBody => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HeadBody] as Parameters.HeadBody;

		public Parameters.Injection Injection => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Injection] as Parameters.Injection;

		public Parameters.LocalAcsMas LocalAcsMas => FactCollection[CoreHelper.InternalParameters.LocalAcsMas] as Parameters.LocalAcsMas;

		public Parameters.LocalConeBeamMaxPitch LocalConeBeamMaxPitch => FactCollection[CoreHelper.InternalParameters.LocalConeBeamMaxPitch] as Parameters.LocalConeBeamMaxPitch;

		public Parameters.LocalCurrentEffFov LocalCurrentEffFov => FactCollection[CoreHelper.InternalParameters.LocalCurrentEffFov] as Parameters.LocalCurrentEffFov;

		public Parameters.LocalDlpFactor LocalDlpFactor => FactCollection[CoreHelper.InternalParameters.LocalDlpFactor] as Parameters.LocalDlpFactor;

		public Parameters.LocalDoseDlpMultiplier LocalDoseDlpMultiplier => FactCollection[CoreHelper.InternalParameters.LocalDoseDlpMultiplier] as Parameters.LocalDoseDlpMultiplier;

		public Parameters.LocalizerAutoOff LocalizerAutoOff => FactCollection[CoreHelper.InternalParameters.LocalizerAutoOff] as Parameters.LocalizerAutoOff;

		public Parameters.LocalManualPitch LocalManualPitch => FactCollection[CoreHelper.InternalParameters.LocalManualPitch] as Parameters.LocalManualPitch;

		public Parameters.LocalMinCycleTime LocalMinCycleTime => FactCollection[CoreHelper.InternalParameters.LocalMinCycleTime] as Parameters.LocalMinCycleTime;

		public Parameters.LocalPitchAndRt LocalPitchAndRt => FactCollection[CoreHelper.InternalParameters.LocalPitchAndRt] as Parameters.LocalPitchAndRt;

		public Parameters.LocalPreciseDoseNoMas LocalPreciseDoseNoMas => FactCollection[CoreHelper.InternalParameters.LocalPreciseDoseNoMas] as Parameters.LocalPreciseDoseNoMas;

		public Parameters.LocalRelativeDose LocalRelativeDose => FactCollection[CoreHelper.InternalParameters.LocalRelativeDose] as Parameters.LocalRelativeDose;

		public Parameters.LocalWindowCenterRange LocalWindowCenterRange => FactCollection[CoreHelper.InternalParameters.LocalWindowCenterRange] as Parameters.LocalWindowCenterRange;

		public Parameters.NumberOfScans NumberOfScans => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NumberOfScans] as Parameters.NumberOfScans;

		public Parameters.PreciseDose PreciseDose => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreciseDose] as Parameters.PreciseDose;

		public Parameters.PreviewCenterXmm PreviewCenterXmm => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewCenterXmm] as Parameters.PreviewCenterXmm;

		public Parameters.PreviewCenterYmm PreviewCenterYmm => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewCenterYmm] as Parameters.PreviewCenterYmm;

		public Parameters.PreviewFieldOfView PreviewFieldOfView => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewFieldOfView] as Parameters.PreviewFieldOfView;

		public Parameters.RadiationDose RadiationDose => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDose] as Parameters.RadiationDose;

		public Parameters.RadiationDoseUI RadiationDoseUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDoseUI] as Parameters.RadiationDoseUI;

		public Parameters.RadiationDoseUpperLimit RadiationDoseUpperLimit => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDoseUpperLimit] as Parameters.RadiationDoseUpperLimit;

		public Parameters.RequestedScanTime RequestedScanTime => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedScanTime] as Parameters.RequestedScanTime;

		public Parameters.Resolution Resolution => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Resolution] as Parameters.Resolution;

		public Parameters.ResolutionUI ResolutionUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ResolutionUI] as Parameters.ResolutionUI;

		public Parameters.RespiratoryDirection RespiratoryDirection => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryDirection] as Parameters.RespiratoryDirection;

		public Parameters.RespiratoryLevel RespiratoryLevel => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryLevel] as Parameters.RespiratoryLevel;

		public Parameters.RespiratoryMode RespiratoryMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryMode] as Parameters.RespiratoryMode;

		public Parameters.ScanTime ScanTime => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanTime] as Parameters.ScanTime;

		public Parameters.ScanTimeUI ScanTimeUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanTimeUI] as Parameters.ScanTimeUI;

		public Parameters.SliceMode SliceMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SliceMode] as Parameters.SliceMode;

		public Parameters.ThicknessUI ThicknessUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ThicknessUI] as Parameters.ThicknessUI;

		public Parameters.Trigger Trigger => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Trigger] as Parameters.Trigger;

		public Parameters.Voltage Voltage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Voltage] as Parameters.Voltage;

		public Parameters.WedgeType WedgeType => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.WedgeType] as Parameters.WedgeType;

		public Parameters.XrayFilter XrayFilter => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.XrayFilter] as Parameters.XrayFilter;

	}

}
