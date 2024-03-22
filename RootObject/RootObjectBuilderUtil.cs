namespace RootObject
{

	public class RootObjectBuilderUtil
	{

		public void SetCTStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AcqSim] = factBuilderUtil.GetFact<System.Boolean, Parameters.AcqSim>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AcqSim);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ChildAdult] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ChildAdult, Parameters.ChildAdult>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ChildAdult);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Collimation] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Collimation, Parameters.Collimation>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Collimation);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ContrastBolusAgent] = factBuilderUtil.GetFact<System.Boolean, Parameters.ContrastBolusAgent>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ContrastBolusAgent);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Current] = factBuilderUtil.GetFact<System.Int32, Parameters.Current>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Current);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Diameter] = factBuilderUtil.GetFact<System.Double, Parameters.Diameter>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Diameter);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DirectionUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Direction, Parameters.DirectionUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DirectionUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Dlp] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDose, Parameters.Dlp>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Dlp);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DlpUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDoseRange, Parameters.DlpUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DlpUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DlpUpperLimit] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDose, Parameters.DlpUpperLimit>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.DlpUpperLimit);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EndPosition] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.EndPosition>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EndPosition);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FirstImagePosition] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.FirstImagePosition>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FirstImagePosition);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FocalSpotType] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.FocalSpot, Parameters.FocalSpotType>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FocalSpotType);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FocusDiameter] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.FocusDiameter, Parameters.FocusDiameter>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FocusDiameter);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HeadBody] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.HeadBody, Parameters.HeadBody>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HeadBody);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Injection] = factBuilderUtil.GetFact<System.Boolean, Parameters.Injection>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Injection);

			rootObject[CoreHelper.InternalParameters.LocalAcsMas] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalAcsMas>();

			rootObject[CoreHelper.InternalParameters.LocalConeBeamMaxPitch] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalConeBeamMaxPitch>();

			rootObject[CoreHelper.InternalParameters.LocalCurrentEffFov] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalCurrentEffFov>();

			rootObject[CoreHelper.InternalParameters.LocalDlpFactor] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalDlpFactor>();

			rootObject[CoreHelper.InternalParameters.LocalDoseDlpMultiplier] = factBuilderUtil.GetEmptyFact<System.Int32, Parameters.LocalDoseDlpMultiplier>();

			rootObject[CoreHelper.InternalParameters.LocalizerAutoOff] = factBuilderUtil.GetEmptyFact<System.Boolean, Parameters.LocalizerAutoOff>();

			rootObject[CoreHelper.InternalParameters.LocalManualPitch] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalManualPitch>();

			rootObject[CoreHelper.InternalParameters.LocalMinCycleTime] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalMinCycleTime>();

			rootObject[CoreHelper.InternalParameters.LocalPitchAndRt] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalPitchAndRt>();

			rootObject[CoreHelper.InternalParameters.LocalPreciseDoseNoMas] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalPreciseDoseNoMas>();

			rootObject[CoreHelper.InternalParameters.LocalRelativeDose] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalRelativeDose>();

			rootObject[CoreHelper.InternalParameters.LocalWindowCenterRange] = factBuilderUtil.GetEmptyFact<System.Double, Parameters.LocalWindowCenterRange>();

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NumberOfScans] = factBuilderUtil.GetFact<System.Int32, Parameters.NumberOfScans>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NumberOfScans);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreciseDose] = factBuilderUtil.GetFact<System.Double, Parameters.PreciseDose>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreciseDose);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewCenterXmm] = factBuilderUtil.GetFact<System.Int32, Parameters.PreviewCenterXmm>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewCenterXmm);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewCenterYmm] = factBuilderUtil.GetFact<System.Int32, Parameters.PreviewCenterYmm>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewCenterYmm);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewFieldOfView] = factBuilderUtil.GetFact<System.Int32, Parameters.PreviewFieldOfView>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PreviewFieldOfView);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDose] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDose, Parameters.RadiationDose>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDose);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDoseUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDoseRange, Parameters.RadiationDoseUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDoseUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDoseUpperLimit] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDose, Parameters.RadiationDoseUpperLimit>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RadiationDoseUpperLimit);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedScanTime] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.TimeType, Parameters.RequestedScanTime>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedScanTime);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Resolution] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Resolution, Parameters.Resolution>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Resolution);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ResolutionUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Resolution, Parameters.ResolutionUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ResolutionUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryDirection] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RespiratoryDirection, Parameters.RespiratoryDirection>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryDirection);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryLevel] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RespiratoryLevel, Parameters.RespiratoryLevel>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryLevel);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryMode] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RespiratoryMode, Parameters.RespiratoryMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RespiratoryMode);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanTime] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.TimeType, Parameters.ScanTime>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanTime);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanTimeUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ScanTimeRange, Parameters.ScanTimeUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanTimeUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SliceMode] = factBuilderUtil.GetFact<System.Int32, Parameters.SliceMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SliceMode);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ThicknessUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Collimation, Parameters.ThicknessUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ThicknessUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Trigger] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Trigger, Parameters.Trigger>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Trigger);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Voltage] = factBuilderUtil.GetFact<System.Int32, Parameters.Voltage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Voltage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.WedgeType] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Wedge, Parameters.WedgeType>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.WedgeType);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.XrayFilter] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.XRayFilter, Parameters.XrayFilter>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.XrayFilter);

		}

		public void SetSurviewStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SurviewLength] = factBuilderUtil.GetFact<System.Double, Parameters.SurviewLength>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SurviewLength);

		}

		public void SetRotatingStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AbsoluteMaxmAsPerSlice] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.DoubleWithNone, Parameters.AbsoluteMaxmAsPerSlice>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AbsoluteMaxmAsPerSlice);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AbsoluteMinmAsPerSlice] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.DoubleWithNone, Parameters.AbsoluteMinmAsPerSlice>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AbsoluteMinmAsPerSlice);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ACS] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ACS, Parameters.ACS>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ACS);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ActualNoiseLevel] = factBuilderUtil.GetFact<System.Int32, Parameters.ActualNoiseLevel>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ActualNoiseLevel);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AngularSampling] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.AngularSampling, Parameters.AngularSampling>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AngularSampling);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BedSpeed] = factBuilderUtil.GetFact<System.Double, Parameters.BedSpeed>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BedSpeed);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusDelta] = factBuilderUtil.GetFact<System.Int32, Parameters.BolusDelta>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusDelta);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusThreasholMode] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.BolusThresholdMode, Parameters.BolusThreasholMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusThreasholMode);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusThreshold] = factBuilderUtil.GetFact<System.Int32, Parameters.BolusThreshold>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.BolusThreshold);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Breathrate] = factBuilderUtil.GetFact<System.Double, Parameters.Breathrate>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Breathrate);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ClinicalApplication] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ClinicalApplication, Parameters.ClinicalApplication>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ClinicalApplication);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Ecg] = factBuilderUtil.GetFact<System.Boolean, Parameters.Ecg>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Ecg);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgDoseIrregularities] = factBuilderUtil.GetFact<System.Boolean, Parameters.EcgDoseIrregularities>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgDoseIrregularities);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgPhaseTolerance] = factBuilderUtil.GetFact<System.Int32, Parameters.EcgPhaseTolerance>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgPhaseTolerance);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Evolving] = factBuilderUtil.GetFact<System.Boolean, Parameters.Evolving>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Evolving);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FDom] = factBuilderUtil.GetFact<System.Boolean, Parameters.FDom>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.FDom);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Heartbeat] = factBuilderUtil.GetFact<System.Double, Parameters.Heartbeat>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Heartbeat);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.JogNumberOfJogs] = factBuilderUtil.GetFact<System.Int32, Parameters.JogNumberOfJogs>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.JogNumberOfJogs);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseLevel] = factBuilderUtil.GetFact<System.Int32, Parameters.NoiseLevel>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseLevel);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Organ] = factBuilderUtil.GetFact<System.String, Parameters.Organ>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Organ);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.OrganUI] = factBuilderUtil.GetFact<System.String, Parameters.OrganUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.OrganUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pulmo] = factBuilderUtil.GetFact<System.Boolean, Parameters.Pulmo>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pulmo);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PulmoByVarian] = factBuilderUtil.GetFact<System.Boolean, Parameters.PulmoByVarian>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PulmoByVarian);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.QuarterDetOffset] = factBuilderUtil.GetFact<System.Boolean, Parameters.QuarterDetOffset>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.QuarterDetOffset);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ReferenceBodySize] = factBuilderUtil.GetFact<System.Int32, Parameters.ReferenceBodySize>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ReferenceBodySize);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ReferencePatientSize] = factBuilderUtil.GetFact<System.Int32, Parameters.ReferencePatientSize>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ReferencePatientSize);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationTime] = factBuilderUtil.GetFact<System.Double, Parameters.RotationTime>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationTime);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationTimeUI] = factBuilderUtil.GetFact<System.Double, Parameters.RotationTimeUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationTimeUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SampledCollimation] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Collimation, Parameters.SampledCollimation>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SampledCollimation);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanConeBeam] = factBuilderUtil.GetFact<System.Boolean, Parameters.ScanConeBeam>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanConeBeam);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanMaxEffFOV] = factBuilderUtil.GetFact<System.Int32, Parameters.ScanMaxEffFOV>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanMaxEffFOV);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SeriesLength] = factBuilderUtil.GetFact<System.Double, Parameters.SeriesLength>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SeriesLength);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SizeSpecificDose] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDose, Parameters.SizeSpecificDose>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SizeSpecificDose);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Tilt] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.Tilt>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Tilt);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ZDom] = factBuilderUtil.GetFact<System.Boolean, Parameters.ZDom>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ZDom);

		}

		public void SetAxialStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AllowBedMovement] = factBuilderUtil.GetFact<System.Boolean, Parameters.AllowBedMovement>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AllowBedMovement);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Apex] = factBuilderUtil.GetFact<System.Boolean, Parameters.Apex>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Apex);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexArrhythmiaSkippedCycles] = factBuilderUtil.GetFact<System.Int32, Parameters.ApexArrhythmiaSkippedCycles>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexArrhythmiaSkippedCycles);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexArrhythmiaTolerance] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ApexArrythmiaTolerance, Parameters.ApexArrhythmiaTolerance>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexArrhythmiaTolerance);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexMaxSeriesTime] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.TimeType, Parameters.ApexMaxSeriesTime>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexMaxSeriesTime);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexMinSeriesTime] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.TimeType, Parameters.ApexMinSeriesTime>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexMinSeriesTime);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AsymmetricStartAngle] = factBuilderUtil.GetFact<System.Boolean, Parameters.AsymmetricStartAngle>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AsymmetricStartAngle);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.CdrhScanAngle240] = factBuilderUtil.GetFact<System.Boolean, Parameters.CdrhScanAngle240>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.CdrhScanAngle240);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.CycleTime] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.TimeWithMinimum, Parameters.CycleTime>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.CycleTime);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgScanPhaseDelay] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Phase, Parameters.EcgScanPhaseDelay>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgScanPhaseDelay);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAs] = factBuilderUtil.GetFact<System.Double, Parameters.MAs>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAs);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pedal] = factBuilderUtil.GetFact<System.Boolean, Parameters.Pedal>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pedal);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PedalMode] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.PedalMode, Parameters.PedalMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PedalMode);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedCycleTime] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.TimeWithMinimum, Parameters.RequestedCycleTime>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedCycleTime);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationsPerScan] = factBuilderUtil.GetFact<System.Double, Parameters.RotationsPerScan>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationsPerScan);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanAngle] = factBuilderUtil.GetFact<System.Int32, Parameters.ScanAngle>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanAngle);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SliceIncrement] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Increment, Parameters.SliceIncrement>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SliceIncrement);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.StartAngle] = factBuilderUtil.GetFact<System.Double, Parameters.StartAngle>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.StartAngle);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.UseStartAngle] = factBuilderUtil.GetFact<System.Boolean, Parameters.UseStartAngle>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.UseStartAngle);

		}

		public void SetHelicalStepFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AutoConeBeam] = factBuilderUtil.GetFact<System.String, Parameters.AutoConeBeam>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AutoConeBeam);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AutoPitchAndRT] = factBuilderUtil.GetFact<System.Boolean, Parameters.AutoPitchAndRT>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AutoPitchAndRT);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ConeBeamPitchOffset] = factBuilderUtil.GetFact<System.Double, Parameters.ConeBeamPitchOffset>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ConeBeamPitchOffset);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgDoseModulation] = factBuilderUtil.GetFact<System.Boolean, Parameters.EcgDoseModulation>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgDoseModulation);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgModulatedDose] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.RadiationDose, Parameters.EcgModulatedDose>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgModulatedDose);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Hds] = factBuilderUtil.GetFact<System.Boolean, Parameters.Hds>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Hds);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HdsLagMicron] = factBuilderUtil.GetFact<System.Double, Parameters.HdsLagMicron>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HdsLagMicron);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HdsLeadMicron] = factBuilderUtil.GetFact<System.Double, Parameters.HdsLeadMicron>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.HdsLeadMicron);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAsForPitchRT] = factBuilderUtil.GetFact<System.Double, Parameters.MAsForPitchRT>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAsForPitchRT);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAsPerSlice] = factBuilderUtil.GetFact<System.Double, Parameters.MAsPerSlice>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAsPerSlice);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MaxmAsPerSlice] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.DoubleWithNone, Parameters.MaxmAsPerSlice>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MaxmAsPerSlice);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MinmAsPerSlice] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.DoubleWithNone, Parameters.MinmAsPerSlice>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MinmAsPerSlice);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ModulationLevel] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ModulationLevel, Parameters.ModulationLevel>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ModulationLevel);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseIndexHeadDelta] = factBuilderUtil.GetFact<System.Int32, Parameters.NoiseIndexHeadDelta>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseIndexHeadDelta);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseIndexLiverDelta] = factBuilderUtil.GetFact<System.Int32, Parameters.NoiseIndexLiverDelta>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.NoiseIndexLiverDelta);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pitch] = factBuilderUtil.GetFact<System.Double, Parameters.Pitch>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pitch);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PulmoTrigger] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.PulmoTrigger, Parameters.PulmoTrigger>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PulmoTrigger);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedMaxmAsPerSlice] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.DoubleWithNone, Parameters.RequestedMaxmAsPerSlice>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedMaxmAsPerSlice);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedMinmAsPerSlice] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.DoubleWithNone, Parameters.RequestedMinmAsPerSlice>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedMinmAsPerSlice);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanLength] = factBuilderUtil.GetFact<System.Double, Parameters.ScanLength>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanLength);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SwiftMode] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.SwiftMode, Parameters.SwiftMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SwiftMode);

		}

		public void SetResultGeneralFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CenterXmm] = factBuilderUtil.GetFact<System.Int32, Parameters.CenterXmm>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CenterXmm);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CenterYmm] = factBuilderUtil.GetFact<System.Int32, Parameters.CenterYmm>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CenterYmm);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ContinuePreviousSeries] = factBuilderUtil.GetFact<System.Boolean, Parameters.ContinuePreviousSeries>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ContinuePreviousSeries);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.DefaultStorage] = factBuilderUtil.GetFact<System.Boolean, Parameters.DefaultStorage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.DefaultStorage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Enhancement] = factBuilderUtil.GetFact<System.Double, Parameters.Enhancement>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Enhancement);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageColumns] = factBuilderUtil.GetFact<System.Int32, Parameters.ImageColumns>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageColumns);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageMatrix] = factBuilderUtil.GetFact<System.Int32, Parameters.ImageMatrix>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageMatrix);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageRows] = factBuilderUtil.GetFact<System.Int32, Parameters.ImageRows>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageRows);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImagesPerScan] = factBuilderUtil.GetFact<System.Int32, Parameters.ImagesPerScan>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImagesPerScan);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IrsStage] = factBuilderUtil.GetFact<System.String, Parameters.IrsStage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IrsStage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IrsSubStage] = factBuilderUtil.GetFact<System.String, Parameters.IrsSubStage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IrsSubStage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.JogNSlices] = factBuilderUtil.GetFact<System.Int32, Parameters.JogNSlices>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.JogNSlices);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprBodyPart] = factBuilderUtil.GetFact<System.String, Parameters.MprBodyPart>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprBodyPart);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprCenterXmm] = factBuilderUtil.GetFact<System.Int32, Parameters.MprCenterXmm>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprCenterXmm);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprCenterYmm] = factBuilderUtil.GetFact<System.Int32, Parameters.MprCenterYmm>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprCenterYmm);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprEndPosition] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.MprEndPosition>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprEndPosition);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFieldOfViewX] = factBuilderUtil.GetFact<System.Int32, Parameters.MprFieldOfViewX>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFieldOfViewX);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFieldOfViewY] = factBuilderUtil.GetFact<System.Int32, Parameters.MprFieldOfViewY>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFieldOfViewY);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFilming] = factBuilderUtil.GetFact<System.Boolean, Parameters.MprFilming>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFilming);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFirstImage] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.MprFirstImage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFirstImage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprIncrement] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Increment, Parameters.MprIncrement>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprIncrement);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprIncrementUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Increment, Parameters.MprIncrementUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprIncrementUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprLength] = factBuilderUtil.GetFact<System.Double, Parameters.MprLength>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprLength);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprMiddleImage] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.MprMiddleImage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprMiddleImage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprNSlices] = factBuilderUtil.GetFact<System.Int32, Parameters.MprNSlices>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprNSlices);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprRenderingMode] = factBuilderUtil.GetFact<Philips.PmsCT.Imaging.Imaging3D.VolumeRenderingMode, Parameters.MprRenderingMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprRenderingMode);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprThickness] = factBuilderUtil.GetFact<System.Double, Parameters.MprThickness>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprThickness);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconFirstImage] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.ReconFirstImage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconFirstImage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconLength] = factBuilderUtil.GetFact<System.Double, Parameters.ReconLength>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconLength);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Reconstruction] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Reconstruction, Parameters.Reconstruction>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Reconstruction);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconstructionUI] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Reconstruction, Parameters.ReconstructionUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconstructionUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconThickness] = factBuilderUtil.GetFact<System.Double, Parameters.ReconThickness>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconThickness);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ReferenceNoise] = factBuilderUtil.GetFact<System.Double, Parameters.ReferenceNoise>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ReferenceNoise);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ResultPriority] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultPriority, Parameters.ResultPriority>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ResultPriority);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.SpectralResult] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.SpectralResultType, Parameters.SpectralResult>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.SpectralResult);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.SpectralResultAssociatedValue] = factBuilderUtil.GetFact<System.Int32, Parameters.SpectralResultAssociatedValue>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.SpectralResultAssociatedValue);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowCenter] = factBuilderUtil.GetFact<System.Int32, Parameters.WindowCenter>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowCenter);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowPreset] = factBuilderUtil.GetFact<System.String, Parameters.WindowPreset>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowPreset);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowWidth] = factBuilderUtil.GetFact<System.Int32, Parameters.WindowWidth>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowWidth);

		}

		public void SetSurviewResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

		}

		public void SetRotatingResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.AdaptiveFilter] = factBuilderUtil.GetFact<System.Boolean, Parameters.AdaptiveFilter>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.AdaptiveFilter);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.AdaptiveFilterCardiacMode] = factBuilderUtil.GetFact<System.Boolean, Parameters.AdaptiveFilterCardiacMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.AdaptiveFilterCardiacMode);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ConeBeam] = factBuilderUtil.GetFact<System.Boolean, Parameters.ConeBeam>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ConeBeam);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Cosmix] = factBuilderUtil.GetFact<System.Boolean, Parameters.Cosmix>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Cosmix);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CrosstalkCorrection] = factBuilderUtil.GetFact<System.Boolean, Parameters.CrosstalkCorrection>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CrosstalkCorrection);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.DetectorDisplacementCorrection] = factBuilderUtil.GetFact<System.Boolean, Parameters.DetectorDisplacementCorrection>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.DetectorDisplacementCorrection);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.EcgPhaseDelay] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Phase, Parameters.EcgPhaseDelay>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.EcgPhaseDelay);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.EcgPhaseType] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.EcgPhaseType, Parameters.EcgPhaseType>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.EcgPhaseType);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Filter] = factBuilderUtil.GetFact<System.String, Parameters.Filter>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Filter);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.FilterUI] = factBuilderUtil.GetFact<System.String, Parameters.FilterUI>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.FilterUI);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDose] = factBuilderUtil.GetFact<System.Boolean, Parameters.iDose>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDose);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseDynamicMaxLevel] = factBuilderUtil.GetFact<System.Int32, Parameters.iDoseDynamicMaxLevel>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseDynamicMaxLevel);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseLevel] = factBuilderUtil.GetFact<System.Int32, Parameters.iDoseLevel>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseLevel);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseMedianNoise] = factBuilderUtil.GetFact<System.Double, Parameters.iDoseMedianNoise>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseMedianNoise);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseMultiResolution] = factBuilderUtil.GetFact<System.Boolean, Parameters.iDoseMultiResolution>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseMultiResolution);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseUserLevel] = factBuilderUtil.GetFact<System.Int32, Parameters.iDoseUserLevel>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.iDoseUserLevel);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IMR] = factBuilderUtil.GetFact<System.Boolean, Parameters.IMR>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IMR);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Jog] = factBuilderUtil.GetFact<System.Boolean, Parameters.Jog>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Jog);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.MetalCorrection] = factBuilderUtil.GetFact<System.Boolean, Parameters.MetalCorrection>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.MetalCorrection);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.MetalProtection] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.MetalProtection, Parameters.MetalProtection>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.MetalProtection);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.NSlices] = factBuilderUtil.GetFact<System.Int32, Parameters.NSlices>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.NSlices);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.OffFocal] = factBuilderUtil.GetFact<System.Boolean, Parameters.OffFocal>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.OffFocal);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.OptsIrsAddNoise] = factBuilderUtil.GetFact<System.Boolean, Parameters.OptsIrsAddNoise>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.OptsIrsAddNoise);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PreciseImage] = factBuilderUtil.GetFact<System.Boolean, Parameters.PreciseImage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PreciseImage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PreciseImageDefinition] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.PreciseImageDefinition, Parameters.PreciseImageDefinition>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PreciseImageDefinition);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PulmoPhaseDelay] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Phase, Parameters.PulmoPhaseDelay>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.PulmoPhaseDelay);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconAngle] = factBuilderUtil.GetFact<System.Int32, Parameters.ReconAngle>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconAngle);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconBinning] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Binning, Parameters.ReconBinning>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconBinning);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconEndPosition] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Position, Parameters.ReconEndPosition>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconEndPosition);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconFieldOfView] = factBuilderUtil.GetFact<System.Int32, Parameters.ReconFieldOfView>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconFieldOfView);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconIncrement] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.Increment, Parameters.ReconIncrement>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconIncrement);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconMaxEffFOV] = factBuilderUtil.GetFact<System.Int32, Parameters.ReconMaxEffFOV>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconMaxEffFOV);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.UltraImage] = factBuilderUtil.GetFact<System.Boolean, Parameters.UltraImage>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.UltraImage);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.UltraImageThreshold] = factBuilderUtil.GetFact<System.Double, Parameters.UltraImageThreshold>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.UltraImageThreshold);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Warp] = factBuilderUtil.GetFact<System.Boolean, Parameters.Warp>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Warp);

		}

		public void SetAxialResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ApexFeathering] = factBuilderUtil.GetFact<System.Boolean, Parameters.ApexFeathering>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ApexFeathering);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.DisplayMode] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.DisplayMode, Parameters.DisplayMode>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.DisplayMode);

			rootObject[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ViewConvention] = factBuilderUtil.GetFact<Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ViewConvention, Parameters.ViewConvention>(ruleDataModel, Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ViewConvention);

		}

		public void SetHelicalResultFacts(CoreHelper.IItem rootObject, ERGenerator.DataModel ruleDataModel, CoreHelper.IFactBuilderUtil factBuilderUtil)
		{

		}

	}
}
