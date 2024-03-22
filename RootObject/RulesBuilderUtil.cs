using System.Collections.Generic;
using CoreHelper;
using Parameters;

namespace RootObject
{

	public class RulesBuilderUtil
	{

		public void AddCTStepRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)
		{

			ruleInfoDictionary["AcqSimValidate"] = new RuleInfo("AcqSimValidate", 10, Category.CTStep, new AcqSimValidate(), false);

			ruleInfoDictionary["ChildAdultValidate"] = new RuleInfo("ChildAdultValidate", 10, Category.CTStep, new ChildAdultValidate(), false);

			ruleInfoDictionary["ContrastBolusAgentValidate"] = new RuleInfo("ContrastBolusAgentValidate", 10, Category.CTStep, new ContrastBolusAgentValidate(), false);

			ruleInfoDictionary["DefaultStorageValidate"] = new RuleInfo("DefaultStorageValidate", 10, Category.CTStep, new DefaultStorageValidate(), false);

			ruleInfoDictionary["DiameterValidate"] = new RuleInfo("DiameterValidate", 10, Category.CTStep, new DiameterValidate(), false);

			ruleInfoDictionary["DirectionUIValidate"] = new RuleInfo("DirectionUIValidate", 10, Category.CTStep, new DirectionUIValidate(), false);

			ruleInfoDictionary["EndPositionValidate"] = new RuleInfo("EndPositionValidate", 10, Category.CTStep, new EndPositionValidate(), false);

			ruleInfoDictionary["FirstImagePositionValidate"] = new RuleInfo("FirstImagePositionValidate", 10, Category.CTStep, new FirstImagePositionValidate(), false);

			ruleInfoDictionary["ImageColumnsValidate"] = new RuleInfo("ImageColumnsValidate", 10, Category.CTStep, new ImageColumnsValidate(), false);

			ruleInfoDictionary["ImageRowsValidate"] = new RuleInfo("ImageRowsValidate", 10, Category.CTStep, new ImageRowsValidate(), false);

			ruleInfoDictionary["InjectionValidate"] = new RuleInfo("InjectionValidate", 10, Category.CTStep, new InjectionValidate(), false);

			ruleInfoDictionary["IrsStageValidate"] = new RuleInfo("IrsStageValidate", 10, Category.CTStep, new IrsStageValidate(), false);

			ruleInfoDictionary["IrsSubStageValidate"] = new RuleInfo("IrsSubStageValidate", 10, Category.CTStep, new IrsSubStageValidate(), false);

			ruleInfoDictionary["ReconFirstImageValidate"] = new RuleInfo("ReconFirstImageValidate", 10, Category.CTStep, new ReconFirstImageValidate(), false);

			ruleInfoDictionary["SliceModeValidate"] = new RuleInfo("SliceModeValidate", 10, Category.CTStep, new SliceModeValidate(), false);

			ruleInfoDictionary["WindowCenterPresetvalidate"] = new RuleInfo("WindowCenterPresetvalidate", 10, Category.CTStep, new WindowCenterPresetvalidate(), false);

			ruleInfoDictionary["WindowWidthvalidate"] = new RuleInfo("WindowWidthvalidate", 10, Category.CTStep, new WindowWidthvalidate(), false);

		}

		public void AddSurviewRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)
		{

			ruleInfoDictionary["CollimationSurviewOptions"] = new RuleInfo("CollimationSurviewOptions", 11, Category.Surview, new CollimationSurviewOptions(), false);

			ruleInfoDictionary["CollimationSurviewValidate"] = new RuleInfo("CollimationSurviewValidate", 10, Category.Surview, new CollimationSurviewValidate(), false);

			ruleInfoDictionary["CurrentSurviewValidate"] = new RuleInfo("CurrentSurviewValidate", 10, Category.Surview, new CurrentSurviewValidate(), false);

			ruleInfoDictionary["FocusDiameterSurviwValidate"] = new RuleInfo("FocusDiameterSurviwValidate", 10, Category.Surview, new FocusDiameterSurviwValidate(), false);

			ruleInfoDictionary["HeadBodySurviewValidate"] = new RuleInfo("HeadBodySurviewValidate", 10, Category.Surview, new HeadBodySurviewValidate(), false);

			ruleInfoDictionary["ImagesPerScanSurviewValidate"] = new RuleInfo("ImagesPerScanSurviewValidate", 10, Category.Surview, new ImagesPerScanSurviewValidate(), false);

			ruleInfoDictionary["LocalPreciseDoseNoMasSurviewValidate"] = new RuleInfo("LocalPreciseDoseNoMasSurviewValidate", 10, Category.Surview, new LocalPreciseDoseNoMasSurviewValidate(), false);

			ruleInfoDictionary["SurviewLengthValidate"] = new RuleInfo("SurviewLengthValidate", 10, Category.Surview, new SurviewLengthValidate(), false);

			ruleInfoDictionary["PreciseDoseSurviewValidate"] = new RuleInfo("PreciseDoseSurviewValidate", 10, Category.Surview, new PreciseDoseSurviewValidate(), false);

			ruleInfoDictionary["RadiationDoseUiSurviewValidate"] = new RuleInfo("RadiationDoseUiSurviewValidate", 10, Category.Surview, new RadiationDoseUiSurviewValidate(), false);

			ruleInfoDictionary["ReconstructionSurviewValidate"] = new RuleInfo("ReconstructionSurviewValidate", 10, Category.Surview, new ReconstructionSurviewValidate(), false);

			ruleInfoDictionary["ResolutionSurviewValidate"] = new RuleInfo("ResolutionSurviewValidate", 10, Category.Surview, new ResolutionSurviewValidate(), false);

			ruleInfoDictionary["ScanTimeUISurviewValidate"] = new RuleInfo("ScanTimeUISurviewValidate", 10, Category.Surview, new ScanTimeUISurviewValidate(), false);

			ruleInfoDictionary["TriggerSurviewValidate"] = new RuleInfo("TriggerSurviewValidate", 10, Category.Surview, new TriggerSurviewValidate(), false);

		}

		public void AddRotatingStepRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)
		{

			ruleInfoDictionary["AbsoluteMaxmAsPerSliceValidate"] = new RuleInfo("AbsoluteMaxmAsPerSliceValidate", 10, Category.RotatingStep, new AbsoluteMaxmAsPerSliceValidate(), false);

			ruleInfoDictionary["AbsoluteMinmAsPerSliceValidate"] = new RuleInfo("AbsoluteMinmAsPerSliceValidate", 10, Category.RotatingStep, new AbsoluteMinmAsPerSliceValidate(), false);

			ruleInfoDictionary["ACSOptionRuleNode"] = new RuleInfo("ACSOptionRuleNode", 11, Category.RotatingStep, new ACSOptionRuleNode(), false);

			ruleInfoDictionary["AdaptiveFilterOrganDefault"] = new RuleInfo("AdaptiveFilterOrganDefault", 11, Category.RotatingStep, new AdaptiveFilterOrganDefault(), false);

			ruleInfoDictionary["AngularSamplingValidate"] = new RuleInfo("AngularSamplingValidate", 10, Category.RotatingStep, new AngularSamplingValidate(), false);

			ruleInfoDictionary["BolusDeltaValidate"] = new RuleInfo("BolusDeltaValidate", 10, Category.RotatingStep, new BolusDeltaValidate(), false);

			ruleInfoDictionary["BolusThreasholModeValidate"] = new RuleInfo("BolusThreasholModeValidate", 10, Category.RotatingStep, new BolusThreasholModeValidate(), false);

			ruleInfoDictionary["BolusThreasholdValidate"] = new RuleInfo("BolusThreasholdValidate", 10, Category.RotatingStep, new BolusThreasholdValidate(), false);

			ruleInfoDictionary["BreathrateValidate"] = new RuleInfo("BreathrateValidate", 10, Category.RotatingStep, new BreathrateValidate(), false);

			ruleInfoDictionary["CenterXmmValidate"] = new RuleInfo("CenterXmmValidate", 10, Category.RotatingStep, new CenterXmmValidate(), false);

			ruleInfoDictionary["CenterYmmValidate"] = new RuleInfo("CenterYmmValidate", 10, Category.RotatingStep, new CenterYmmValidate(), false);

			ruleInfoDictionary["CollimationValidate"] = new RuleInfo("CollimationValidate", 10, Category.RotatingStep, new CollimationValidate(), false);

			ruleInfoDictionary["ContinuePreviousSeriesOptions"] = new RuleInfo("ContinuePreviousSeriesOptions", 11, Category.RotatingStep, new ContinuePreviousSeriesOptions(), false);

			ruleInfoDictionary["CosmixValidate"] = new RuleInfo("CosmixValidate", 10, Category.RotatingStep, new CosmixValidate(), false);

			ruleInfoDictionary["CrosstalkCorrectionValidate"] = new RuleInfo("CrosstalkCorrectionValidate", 10, Category.RotatingStep, new CrosstalkCorrectionValidate(), false);

			ruleInfoDictionary["DetectorDisplacementCorrectionValidate"] = new RuleInfo("DetectorDisplacementCorrectionValidate", 10, Category.RotatingStep, new DetectorDisplacementCorrectionValidate(), false);

			ruleInfoDictionary["FocusDiameterValidate"] = new RuleInfo("FocusDiameterValidate", 10, Category.RotatingStep, new FocusDiameterValidate(), false);

			ruleInfoDictionary["HeadBodyValidate"] = new RuleInfo("HeadBodyValidate", 10, Category.RotatingStep, new HeadBodyValidate(), false);

			ruleInfoDictionary["HeadBodyHelixAxialOrganDefault"] = new RuleInfo("HeadBodyHelixAxialOrganDefault", 11, Category.RotatingStep, new HeadBodyHelixAxialOrganDefault(), false);

			ruleInfoDictionary["IDoseValidate"] = new RuleInfo("IDoseValidate", 10, Category.RotatingStep, new IDoseValidate(), false);

			ruleInfoDictionary["iDoseDynamicMaxLevelPostLoadlValidate"] = new RuleInfo("iDoseDynamicMaxLevelPostLoadlValidate", 10, Category.RotatingStep, new iDoseDynamicMaxLevelPostLoadlValidate(), false);

			ruleInfoDictionary["iDoseDynamicMaxLevelEditlValidate"] = new RuleInfo("iDoseDynamicMaxLevelEditlValidate", 10, Category.RotatingStep, new iDoseDynamicMaxLevelEditlValidate(), false);

			ruleInfoDictionary["iDoseMultiResolutionValidate"] = new RuleInfo("iDoseMultiResolutionValidate", 10, Category.RotatingStep, new iDoseMultiResolutionValidate(), false);

			ruleInfoDictionary["iDoseUserLevelValidate"] = new RuleInfo("iDoseUserLevelValidate", 10, Category.RotatingStep, new iDoseUserLevelValidate(), false);

			ruleInfoDictionary["IMRValidate"] = new RuleInfo("IMRValidate", 10, Category.RotatingStep, new IMRValidate(), false);

			ruleInfoDictionary["JogValidate"] = new RuleInfo("JogValidate", 10, Category.RotatingStep, new JogValidate(), false);

			ruleInfoDictionary["JogNSlicesValidate"] = new RuleInfo("JogNSlicesValidate", 10, Category.RotatingStep, new JogNSlicesValidate(), false);

			ruleInfoDictionary["JogNumberOfJogsValidate"] = new RuleInfo("JogNumberOfJogsValidate", 10, Category.RotatingStep, new JogNumberOfJogsValidate(), false);

			ruleInfoDictionary["JogNumberOfJogsNonJogValidate"] = new RuleInfo("JogNumberOfJogsNonJogValidate", 10, Category.RotatingStep, new JogNumberOfJogsNonJogValidate(), false);

			ruleInfoDictionary["LocalCurrentEffFovValidate"] = new RuleInfo("LocalCurrentEffFovValidate", 10, Category.RotatingStep, new LocalCurrentEffFovValidate(), false);

			ruleInfoDictionary["MetalProtectionValidate"] = new RuleInfo("MetalProtectionValidate", 10, Category.RotatingStep, new MetalProtectionValidate(), false);

			ruleInfoDictionary["MprCenterXmmValidate"] = new RuleInfo("MprCenterXmmValidate", 10, Category.RotatingStep, new MprCenterXmmValidate(), false);

			ruleInfoDictionary["MprCenterYmmValidate"] = new RuleInfo("MprCenterYmmValidate", 10, Category.RotatingStep, new MprCenterYmmValidate(), false);

			ruleInfoDictionary["MprEndPositionValidate"] = new RuleInfo("MprEndPositionValidate", 10, Category.RotatingStep, new MprEndPositionValidate(), false);

			ruleInfoDictionary["MprFilmingValidate"] = new RuleInfo("MprFilmingValidate", 10, Category.RotatingStep, new MprFilmingValidate(), false);

			ruleInfoDictionary["MprFirstImageValidate"] = new RuleInfo("MprFirstImageValidate", 10, Category.RotatingStep, new MprFirstImageValidate(), false);

			ruleInfoDictionary["MprIncrementUiValidate"] = new RuleInfo("MprIncrementUiValidate", 10, Category.RotatingStep, new MprIncrementUiValidate(), false);

			ruleInfoDictionary["MprLengthValidate"] = new RuleInfo("MprLengthValidate", 10, Category.RotatingStep, new MprLengthValidate(), false);

			ruleInfoDictionary["MprMiddleImageValidate"] = new RuleInfo("MprMiddleImageValidate", 10, Category.RotatingStep, new MprMiddleImageValidate(), false);

			ruleInfoDictionary["MprNSlicesValidate"] = new RuleInfo("MprNSlicesValidate", 10, Category.RotatingStep, new MprNSlicesValidate(), false);

			ruleInfoDictionary["MprNSlicesSetMprNSlicesMax"] = new RuleInfo("MprNSlicesSetMprNSlicesMax", 11, Category.RotatingStep, new MprNSlicesSetMprNSlicesMax(), false);

			ruleInfoDictionary["MprThicknessDontCareValidate"] = new RuleInfo("MprThicknessDontCareValidate", 10, Category.RotatingStep, new MprThicknessDontCareValidate(), false);

			ruleInfoDictionary["NSlicesValidate"] = new RuleInfo("NSlicesValidate", 10, Category.RotatingStep, new NSlicesValidate(), false);

			ruleInfoDictionary["OffFocalValidate"] = new RuleInfo("OffFocalValidate", 10, Category.RotatingStep, new OffFocalValidate(), false);

			ruleInfoDictionary["OptsIrsAddNoiseValidate"] = new RuleInfo("OptsIrsAddNoiseValidate", 10, Category.RotatingStep, new OptsIrsAddNoiseValidate(), false);

			ruleInfoDictionary["PreviewCenterXmmValidate"] = new RuleInfo("PreviewCenterXmmValidate", 10, Category.RotatingStep, new PreviewCenterXmmValidate(), false);

			ruleInfoDictionary["PreviewCenterYmmValidate"] = new RuleInfo("PreviewCenterYmmValidate", 10, Category.RotatingStep, new PreviewCenterYmmValidate(), false);

			ruleInfoDictionary["PulmoValidate"] = new RuleInfo("PulmoValidate", 10, Category.RotatingStep, new PulmoValidate(), false);

			ruleInfoDictionary["ReconIncrementValidate"] = new RuleInfo("ReconIncrementValidate", 10, Category.RotatingStep, new ReconIncrementValidate(), false);

			ruleInfoDictionary["ReconstructionValidate"] = new RuleInfo("ReconstructionValidate", 10, Category.RotatingStep, new ReconstructionValidate(), false);

			ruleInfoDictionary["ReconThicknessValidate"] = new RuleInfo("ReconThicknessValidate", 10, Category.RotatingStep, new ReconThicknessValidate(), false);

			ruleInfoDictionary["ReferenceBodySizeValidate"] = new RuleInfo("ReferenceBodySizeValidate", 10, Category.RotatingStep, new ReferenceBodySizeValidate(), false);

			ruleInfoDictionary["ReferencePatientSizeValidate"] = new RuleInfo("ReferencePatientSizeValidate", 10, Category.RotatingStep, new ReferencePatientSizeValidate(), false);

			ruleInfoDictionary["ResolutionHelixAxialValidate"] = new RuleInfo("ResolutionHelixAxialValidate", 10, Category.RotatingStep, new ResolutionHelixAxialValidate(), false);

			ruleInfoDictionary["RespiratoryDirectionValidate"] = new RuleInfo("RespiratoryDirectionValidate", 10, Category.RotatingStep, new RespiratoryDirectionValidate(), false);

			ruleInfoDictionary["RespiratoryLevelValidate"] = new RuleInfo("RespiratoryLevelValidate", 10, Category.RotatingStep, new RespiratoryLevelValidate(), false);

			ruleInfoDictionary["ResultPriorityValidate"] = new RuleInfo("ResultPriorityValidate", 10, Category.RotatingStep, new ResultPriorityValidate(), false);

			ruleInfoDictionary["RotationTimeUIValidate"] = new RuleInfo("RotationTimeUIValidate", 10, Category.RotatingStep, new RotationTimeUIValidate(), false);

			ruleInfoDictionary["SampledCollimationValidate"] = new RuleInfo("SampledCollimationValidate", 10, Category.RotatingStep, new SampledCollimationValidate(), false);

			ruleInfoDictionary["ScanConeBeamValidate"] = new RuleInfo("ScanConeBeamValidate", 10, Category.RotatingStep, new ScanConeBeamValidate(), false);

			ruleInfoDictionary["SeriesLengthValidate"] = new RuleInfo("SeriesLengthValidate", 10, Category.RotatingStep, new SeriesLengthValidate(), false);

			ruleInfoDictionary["SpectralResultValidate"] = new RuleInfo("SpectralResultValidate", 10, Category.RotatingStep, new SpectralResultValidate(), false);

			ruleInfoDictionary["ThicknessUiValidate"] = new RuleInfo("ThicknessUiValidate", 10, Category.RotatingStep, new ThicknessUiValidate(), false);

			ruleInfoDictionary["UltraImageValidate"] = new RuleInfo("UltraImageValidate", 10, Category.RotatingStep, new UltraImageValidate(), false);

			ruleInfoDictionary["UltraImageThresholdValidate"] = new RuleInfo("UltraImageThresholdValidate", 10, Category.RotatingStep, new UltraImageThresholdValidate(), false);

			ruleInfoDictionary["XRayFilterValidate"] = new RuleInfo("XRayFilterValidate", 10, Category.RotatingStep, new XRayFilterValidate(), false);

		}

		public void AddAxialRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)
		{

			ruleInfoDictionary["ACSAxialValidate"] = new RuleInfo("ACSAxialValidate", 10, Category.Axial, new ACSAxialValidate(), false);

			ruleInfoDictionary["ActualNoiseLevelAxial"] = new RuleInfo("ActualNoiseLevelAxial", 10, Category.Axial, new ActualNoiseLevelAxial(), false);

			ruleInfoDictionary["AdaptiveFilterOptionsAxial"] = new RuleInfo("AdaptiveFilterOptionsAxial", 11, Category.Axial, new AdaptiveFilterOptionsAxial(), false);

			ruleInfoDictionary["AdaptiveFilterAxialValidate"] = new RuleInfo("AdaptiveFilterAxialValidate", 10, Category.Axial, new AdaptiveFilterAxialValidate(), false);

			ruleInfoDictionary["AllowBedMovementValidate"] = new RuleInfo("AllowBedMovementValidate", 10, Category.Axial, new AllowBedMovementValidate(), false);

			ruleInfoDictionary["ApexValidate"] = new RuleInfo("ApexValidate", 10, Category.Axial, new ApexValidate(), false);

			ruleInfoDictionary["ApexArrhythmiaSkippedCyclesOptions"] = new RuleInfo("ApexArrhythmiaSkippedCyclesOptions", 11, Category.Axial, new ApexArrhythmiaSkippedCyclesOptions(), false);

			ruleInfoDictionary["ApexArrhythmiaSkippedCyclesValidate"] = new RuleInfo("ApexArrhythmiaSkippedCyclesValidate", 10, Category.Axial, new ApexArrhythmiaSkippedCyclesValidate(), false);

			ruleInfoDictionary["ApexArrhythmiaToleranceOptions"] = new RuleInfo("ApexArrhythmiaToleranceOptions", 10, Category.Axial, new ApexArrhythmiaToleranceOptions(), false);

			ruleInfoDictionary["ApexArrhythmiaToleranceValidate"] = new RuleInfo("ApexArrhythmiaToleranceValidate", 10, Category.Axial, new ApexArrhythmiaToleranceValidate(), false);

			ruleInfoDictionary["ApexFeatheringValidate"] = new RuleInfo("ApexFeatheringValidate", 10, Category.Axial, new ApexFeatheringValidate(), false);

			ruleInfoDictionary["ApexMaxSeriesTimeValidate"] = new RuleInfo("ApexMaxSeriesTimeValidate", 10, Category.Axial, new ApexMaxSeriesTimeValidate(), false);

			ruleInfoDictionary["ApexMinSeriesTimeValidate"] = new RuleInfo("ApexMinSeriesTimeValidate", 10, Category.Axial, new ApexMinSeriesTimeValidate(), false);

			ruleInfoDictionary["AsymmetricStartAngleValidate"] = new RuleInfo("AsymmetricStartAngleValidate", 10, Category.Axial, new AsymmetricStartAngleValidate(), false);

			ruleInfoDictionary["BedSpeedAxialValidate"] = new RuleInfo("BedSpeedAxialValidate", 10, Category.Axial, new BedSpeedAxialValidate(), false);

			ruleInfoDictionary["CdrhScanAngle240Validate"] = new RuleInfo("CdrhScanAngle240Validate", 10, Category.Axial, new CdrhScanAngle240Validate(), false);

			ruleInfoDictionary["CollimationAxialOptions"] = new RuleInfo("CollimationAxialOptions", 11, Category.Axial, new CollimationAxialOptions(), false);

			ruleInfoDictionary["ContinuePreviousSeriesAxialValidate"] = new RuleInfo("ContinuePreviousSeriesAxialValidate", 10, Category.Axial, new ContinuePreviousSeriesAxialValidate(), false);

			ruleInfoDictionary["CurrentAxialValidate"] = new RuleInfo("CurrentAxialValidate", 10, Category.Axial, new CurrentAxialValidate(), false);

			ruleInfoDictionary["CycleTimeValidate"] = new RuleInfo("CycleTimeValidate", 10, Category.Axial, new CycleTimeValidate(), false);

			ruleInfoDictionary["DirectionUISprEditValidate"] = new RuleInfo("DirectionUISprEditValidate", 10, Category.Axial, new DirectionUISprEditValidate(), false);

			ruleInfoDictionary["DisplayModeOptions"] = new RuleInfo("DisplayModeOptions", 11, Category.Axial, new DisplayModeOptions(), false);

			ruleInfoDictionary["DisplayModeNonCCTValidate"] = new RuleInfo("DisplayModeNonCCTValidate", 10, Category.Axial, new DisplayModeNonCCTValidate(), false);

			ruleInfoDictionary["DisplayModeCCTValidate"] = new RuleInfo("DisplayModeCCTValidate", 10, Category.Axial, new DisplayModeCCTValidate(), false);

			ruleInfoDictionary["DlpUIAxialValidate"] = new RuleInfo("DlpUIAxialValidate", 10, Category.Axial, new DlpUIAxialValidate(), false);

			ruleInfoDictionary["DlpUpperLimitAxialValidate"] = new RuleInfo("DlpUpperLimitAxialValidate", 10, Category.Axial, new DlpUpperLimitAxialValidate(), false);

			ruleInfoDictionary["EcgAxialValidate"] = new RuleInfo("EcgAxialValidate", 10, Category.Axial, new EcgAxialValidate(), false);

			ruleInfoDictionary["EcgDoseIrregularitiesAxialValidate"] = new RuleInfo("EcgDoseIrregularitiesAxialValidate", 10, Category.Axial, new EcgDoseIrregularitiesAxialValidate(), false);

			ruleInfoDictionary["EcgPhaseDelayAxialValidate"] = new RuleInfo("EcgPhaseDelayAxialValidate", 10, Category.Axial, new EcgPhaseDelayAxialValidate(), false);

			ruleInfoDictionary["EcgPhaseToleranceAxialValidate"] = new RuleInfo("EcgPhaseToleranceAxialValidate", 10, Category.Axial, new EcgPhaseToleranceAxialValidate(), false);

			ruleInfoDictionary["EcgPhaseTypeAxialValidate"] = new RuleInfo("EcgPhaseTypeAxialValidate", 10, Category.Axial, new EcgPhaseTypeAxialValidate(), false);

			ruleInfoDictionary["EcgScanPhaseAxialValidate"] = new RuleInfo("EcgScanPhaseAxialValidate", 10, Category.Axial, new EcgScanPhaseAxialValidate(), false);

			ruleInfoDictionary["IDoseOptionsAxial"] = new RuleInfo("IDoseOptionsAxial", 11, Category.Axial, new IDoseOptionsAxial(), false);

			ruleInfoDictionary["ImagesPerScanAxialValidate"] = new RuleInfo("ImagesPerScanAxialValidate", 10, Category.Axial, new ImagesPerScanAxialValidate(), false);

			ruleInfoDictionary["IMRAxialOptions"] = new RuleInfo("IMRAxialOptions", 11, Category.Axial, new IMRAxialOptions(), false);

			ruleInfoDictionary["LocalDlpFactorIncr0Validate"] = new RuleInfo("LocalDlpFactorIncr0Validate", 10, Category.Axial, new LocalDlpFactorIncr0Validate(), false);

			ruleInfoDictionary["LocalDlpFactorValidate"] = new RuleInfo("LocalDlpFactorValidate", 10, Category.Axial, new LocalDlpFactorValidate(), false);

			ruleInfoDictionary["LocalPreciseDoseNoMasAxialValidate"] = new RuleInfo("LocalPreciseDoseNoMasAxialValidate", 10, Category.Axial, new LocalPreciseDoseNoMasAxialValidate(), false);

			ruleInfoDictionary["LocalRelativeDoseAxialValidate"] = new RuleInfo("LocalRelativeDoseAxialValidate", 10, Category.Axial, new LocalRelativeDoseAxialValidate(), true);

			ruleInfoDictionary["PedalValidate"] = new RuleInfo("PedalValidate", 10, Category.Axial, new PedalValidate(), false);

			ruleInfoDictionary["PulmoPhaseDelayAxialValidate"] = new RuleInfo("PulmoPhaseDelayAxialValidate", 10, Category.Axial, new PulmoPhaseDelayAxialValidate(), false);

			ruleInfoDictionary["RadiationDoseUiAxialValidate"] = new RuleInfo("RadiationDoseUiAxialValidate", 10, Category.Axial, new RadiationDoseUiAxialValidate(), false);

			ruleInfoDictionary["RadiationDoseUpperLimitAxialValidate"] = new RuleInfo("RadiationDoseUpperLimitAxialValidate", 10, Category.Axial, new RadiationDoseUpperLimitAxialValidate(), false);

			ruleInfoDictionary["ReconThicknessAxialOptionsAndMenu"] = new RuleInfo("ReconThicknessAxialOptionsAndMenu", 11, Category.Axial, new ReconThicknessAxialOptionsAndMenu(), false);

			ruleInfoDictionary["ReferenceNoiseAxialValidate"] = new RuleInfo("ReferenceNoiseAxialValidate", 10, Category.Axial, new ReferenceNoiseAxialValidate(), false);

			ruleInfoDictionary["ScanAngleValidate"] = new RuleInfo("ScanAngleValidate", 10, Category.Axial, new ScanAngleValidate(), false);

			ruleInfoDictionary["ScanTimeUIAxialECGValidate"] = new RuleInfo("ScanTimeUIAxialECGValidate", 10, Category.Axial, new ScanTimeUIAxialECGValidate(), false);

			ruleInfoDictionary["ScanTimeUIAxialFluoroValidate"] = new RuleInfo("ScanTimeUIAxialFluoroValidate", 10, Category.Axial, new ScanTimeUIAxialFluoroValidate(), false);

			ruleInfoDictionary["ScanTimeUIAxialValidate"] = new RuleInfo("ScanTimeUIAxialValidate", 10, Category.Axial, new ScanTimeUIAxialValidate(), false);

			ruleInfoDictionary["SliceIncrementValidate"] = new RuleInfo("SliceIncrementValidate", 10, Category.Axial, new SliceIncrementValidate(), false);

			ruleInfoDictionary["SliceIncrementAxialMenu"] = new RuleInfo("SliceIncrementAxialMenu", 10, Category.Axial, new SliceIncrementAxialMenu(), false);

			ruleInfoDictionary["StartAngleAxialValidate"] = new RuleInfo("StartAngleAxialValidate", 10, Category.Axial, new StartAngleAxialValidate(), false);

			ruleInfoDictionary["TiltValidate"] = new RuleInfo("TiltValidate", 10, Category.Axial, new TiltValidate(), false);

			ruleInfoDictionary["TriggerAxialValidate"] = new RuleInfo("TriggerAxialValidate", 10, Category.Axial, new TriggerAxialValidate(), false);

			ruleInfoDictionary["TriggerAxialOptions"] = new RuleInfo("TriggerAxialOptions", 11, Category.Axial, new TriggerAxialOptions(), false);

			ruleInfoDictionary["UseStartAngleValidate"] = new RuleInfo("UseStartAngleValidate", 10, Category.Axial, new UseStartAngleValidate(), false);

			ruleInfoDictionary["ViewConventionValidate"] = new RuleInfo("ViewConventionValidate", 10, Category.Axial, new ViewConventionValidate(), false);

			ruleInfoDictionary["ViewConventionOptionsAndMenu"] = new RuleInfo("ViewConventionOptionsAndMenu", 11, Category.Axial, new ViewConventionOptionsAndMenu(), false);

		}

		public void AddHelixRules(IDictionary<string, IRuleInfo> ruleInfoDictionary)
		{

			ruleInfoDictionary["ACSHelixValidate"] = new RuleInfo("ACSHelixValidate", 10, Category.Helix, new ACSHelixValidate(), false);

			ruleInfoDictionary["ActualNoiseLevelHelix"] = new RuleInfo("ActualNoiseLevelHelix", 10, Category.Helix, new ActualNoiseLevelHelix(), false);

			ruleInfoDictionary["AdaptiveFilterOptionsHelix"] = new RuleInfo("AdaptiveFilterOptionsHelix", 11, Category.Helix, new AdaptiveFilterOptionsHelix(), false);

			ruleInfoDictionary["AdaptiveFilterHelixValidate"] = new RuleInfo("AdaptiveFilterHelixValidate", 10, Category.Helix, new AdaptiveFilterHelixValidate(), false);

			ruleInfoDictionary["AdaptiveFilterCardiacModeValidate"] = new RuleInfo("AdaptiveFilterCardiacModeValidate", 10, Category.Helix, new AdaptiveFilterCardiacModeValidate(), false);

			ruleInfoDictionary["AutoPitchAndRTOptionsHelix"] = new RuleInfo("AutoPitchAndRTOptionsHelix", 10, Category.Helix, new AutoPitchAndRTOptionsHelix(), false);

			ruleInfoDictionary["AutoPitchAndRTHelixValidate"] = new RuleInfo("AutoPitchAndRTHelixValidate", 10, Category.Helix, new AutoPitchAndRTHelixValidate(), false);

			ruleInfoDictionary["BedSpeedHelixSetMinMax"] = new RuleInfo("BedSpeedHelixSetMinMax", 11, Category.Helix, new BedSpeedHelixSetMinMax(), false);

			ruleInfoDictionary["BedSpeedHelixValidate"] = new RuleInfo("BedSpeedHelixValidate", 10, Category.Helix, new BedSpeedHelixValidate(), false);

			ruleInfoDictionary["CollimationHelixOptions"] = new RuleInfo("CollimationHelixOptions", 11, Category.Helix, new CollimationHelixOptions(), false);

			ruleInfoDictionary["ConeBeamOptions"] = new RuleInfo("ConeBeamOptions", 11, Category.Helix, new ConeBeamOptions(), false);

			ruleInfoDictionary["ConeBeamHelixValidate"] = new RuleInfo("ConeBeamHelixValidate", 10, Category.Helix, new ConeBeamHelixValidate(), false);

			ruleInfoDictionary["ConeBeamOrganDefault"] = new RuleInfo("ConeBeamOrganDefault", 11, Category.Helix, new ConeBeamOrganDefault(), false);

			ruleInfoDictionary["ContinuePreviousSeriesHelixValidate"] = new RuleInfo("ContinuePreviousSeriesHelixValidate", 10, Category.Helix, new ContinuePreviousSeriesHelixValidate(), false);

			ruleInfoDictionary["CurrentHelixValidate"] = new RuleInfo("CurrentHelixValidate", 10, Category.Helix, new CurrentHelixValidate(), false);

			ruleInfoDictionary["DlpUpperLimitHelixValidate"] = new RuleInfo("DlpUpperLimitHelixValidate", 10, Category.Helix, new DlpUpperLimitHelixValidate(), false);

			ruleInfoDictionary["EcgHelixValidate"] = new RuleInfo("EcgHelixValidate", 10, Category.Helix, new EcgHelixValidate(), false);

			ruleInfoDictionary["EcgDoseIrregularitiesHelixValidate"] = new RuleInfo("EcgDoseIrregularitiesHelixValidate", 10, Category.Helix, new EcgDoseIrregularitiesHelixValidate(), false);

			ruleInfoDictionary["EcgDoseModulationValidate"] = new RuleInfo("EcgDoseModulationValidate", 10, Category.Helix, new EcgDoseModulationValidate(), false);

			ruleInfoDictionary["EcgModulatedDoseValidate"] = new RuleInfo("EcgModulatedDoseValidate", 10, Category.Helix, new EcgModulatedDoseValidate(), false);

			ruleInfoDictionary["EcgPhaseDelayHelixValidate"] = new RuleInfo("EcgPhaseDelayHelixValidate", 10, Category.Helix, new EcgPhaseDelayHelixValidate(), false);

			ruleInfoDictionary["EcgPhaseToleranceHelixValidate"] = new RuleInfo("EcgPhaseToleranceHelixValidate", 10, Category.Helix, new EcgPhaseToleranceHelixValidate(), false);

			ruleInfoDictionary["EcgPhaseTypeHelixValidate"] = new RuleInfo("EcgPhaseTypeHelixValidate", 10, Category.Helix, new EcgPhaseTypeHelixValidate(), false);

			ruleInfoDictionary["HdsValidate"] = new RuleInfo("HdsValidate", 10, Category.Helix, new HdsValidate(), false);

			ruleInfoDictionary["HdsLagMicronValidate"] = new RuleInfo("HdsLagMicronValidate", 10, Category.Helix, new HdsLagMicronValidate(), false);

			ruleInfoDictionary["HdsLeadMicronValidate"] = new RuleInfo("HdsLeadMicronValidate", 10, Category.Helix, new HdsLeadMicronValidate(), false);

			ruleInfoDictionary["IDoseOptionsHelix"] = new RuleInfo("IDoseOptionsHelix", 11, Category.Helix, new IDoseOptionsHelix(), false);

			ruleInfoDictionary["ImagesPerScanHelixValidate"] = new RuleInfo("ImagesPerScanHelixValidate", 10, Category.Helix, new ImagesPerScanHelixValidate(), false);

			ruleInfoDictionary["IMRHelixOptions"] = new RuleInfo("IMRHelixOptions", 11, Category.Helix, new IMRHelixOptions(), false);

			ruleInfoDictionary["LocalManualPitchValidate"] = new RuleInfo("LocalManualPitchValidate", 10, Category.Helix, new LocalManualPitchValidate(), false);

			ruleInfoDictionary["LocalPreciseDoseNoMasHelixValidate"] = new RuleInfo("LocalPreciseDoseNoMasHelixValidate", 10, Category.Helix, new LocalPreciseDoseNoMasHelixValidate(), false);

			ruleInfoDictionary["LocalRelativeDoseHelixValidate"] = new RuleInfo("LocalRelativeDoseHelixValidate", 10, Category.Helix, new LocalRelativeDoseHelixValidate(), true);

			ruleInfoDictionary["MaxmAsPerSliceValidate"] = new RuleInfo("MaxmAsPerSliceValidate", 10, Category.Helix, new MaxmAsPerSliceValidate(), false);

			ruleInfoDictionary["ModulationLevelValidate"] = new RuleInfo("ModulationLevelValidate", 10, Category.Helix, new ModulationLevelValidate(), false);

			ruleInfoDictionary["PulmoPhaseDelayHelixValidate"] = new RuleInfo("PulmoPhaseDelayHelixValidate", 10, Category.Helix, new PulmoPhaseDelayHelixValidate(), false);

			ruleInfoDictionary["RadiationDoseUiHelixValidate"] = new RuleInfo("RadiationDoseUiHelixValidate", 10, Category.Helix, new RadiationDoseUiHelixValidate(), false);

			ruleInfoDictionary["RadiationDoseUpperLimitHelixValidate"] = new RuleInfo("RadiationDoseUpperLimitHelixValidate", 10, Category.Helix, new RadiationDoseUpperLimitHelixValidate(), false);

			ruleInfoDictionary["ReconThicknessHelixOptionsAndMenu"] = new RuleInfo("ReconThicknessHelixOptionsAndMenu", 11, Category.Helix, new ReconThicknessHelixOptionsAndMenu(), false);

			ruleInfoDictionary["ReferenceNoiseHelixValidate"] = new RuleInfo("ReferenceNoiseHelixValidate", 10, Category.Helix, new ReferenceNoiseHelixValidate(), false);

			ruleInfoDictionary["RequestedMaxmAsPerSliceValidate"] = new RuleInfo("RequestedMaxmAsPerSliceValidate", 10, Category.Helix, new RequestedMaxmAsPerSliceValidate(), false);

			ruleInfoDictionary["RequestedMinmAsPerSliceValidate"] = new RuleInfo("RequestedMinmAsPerSliceValidate", 10, Category.Helix, new RequestedMinmAsPerSliceValidate(), false);

			ruleInfoDictionary["ScanTimeUIHelixValidate"] = new RuleInfo("ScanTimeUIHelixValidate", 10, Category.Helix, new ScanTimeUIHelixValidate(), false);

			ruleInfoDictionary["SeriesLengthSetMinNumofCollimation"] = new RuleInfo("SeriesLengthSetMinNumofCollimation", 11, Category.Helix, new SeriesLengthSetMinNumofCollimation(), false);

			ruleInfoDictionary["SwiftModeValidate"] = new RuleInfo("SwiftModeValidate", 10, Category.Helix, new SwiftModeValidate(), false);

			ruleInfoDictionary["TriggerHelixValidate"] = new RuleInfo("TriggerHelixValidate", 10, Category.Helix, new TriggerHelixValidate(), false);

			ruleInfoDictionary["TriggerHelixOptions"] = new RuleInfo("TriggerHelixOptions", 11, Category.Helix, new TriggerHelixOptions(), false);

			ruleInfoDictionary["ZDomHelixValidate"] = new RuleInfo("ZDomHelixValidate", 10, Category.Helix, new ZDomHelixValidate(), false);

		}

	}
}
