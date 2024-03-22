namespace RootObject
{

	public interface IAxialStepRootObject : IRotatingStepRootObject
	{

		Parameters.AllowBedMovement AllowBedMovement { get; }

		Parameters.Apex Apex { get; }

		Parameters.ApexArrhythmiaSkippedCycles ApexArrhythmiaSkippedCycles { get; }

		Parameters.ApexArrhythmiaTolerance ApexArrhythmiaTolerance { get; }

		Parameters.ApexMaxSeriesTime ApexMaxSeriesTime { get; }

		Parameters.ApexMinSeriesTime ApexMinSeriesTime { get; }

		Parameters.AsymmetricStartAngle AsymmetricStartAngle { get; }

		Parameters.CdrhScanAngle240 CdrhScanAngle240 { get; }

		Parameters.CycleTime CycleTime { get; }

		Parameters.EcgScanPhaseDelay EcgScanPhaseDelay { get; }

		Parameters.MAs MAs { get; }

		Parameters.Pedal Pedal { get; }

		Parameters.PedalMode PedalMode { get; }

		Parameters.RequestedCycleTime RequestedCycleTime { get; }

		Parameters.RotationsPerScan RotationsPerScan { get; }

		Parameters.ScanAngle ScanAngle { get; }

		Parameters.SliceIncrement SliceIncrement { get; }

		Parameters.StartAngle StartAngle { get; }

		Parameters.UseStartAngle UseStartAngle { get; }

	}

	public class AxialStepRootObject : RotatingStepRootObject, IAxialStepRootObject
	{

		public AxialStepRootObject(System.Guid id) : base(id) {}

		public Parameters.AllowBedMovement AllowBedMovement => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AllowBedMovement] as Parameters.AllowBedMovement;

		public Parameters.Apex Apex => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Apex] as Parameters.Apex;

		public Parameters.ApexArrhythmiaSkippedCycles ApexArrhythmiaSkippedCycles => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexArrhythmiaSkippedCycles] as Parameters.ApexArrhythmiaSkippedCycles;

		public Parameters.ApexArrhythmiaTolerance ApexArrhythmiaTolerance => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexArrhythmiaTolerance] as Parameters.ApexArrhythmiaTolerance;

		public Parameters.ApexMaxSeriesTime ApexMaxSeriesTime => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexMaxSeriesTime] as Parameters.ApexMaxSeriesTime;

		public Parameters.ApexMinSeriesTime ApexMinSeriesTime => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ApexMinSeriesTime] as Parameters.ApexMinSeriesTime;

		public Parameters.AsymmetricStartAngle AsymmetricStartAngle => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.AsymmetricStartAngle] as Parameters.AsymmetricStartAngle;

		public Parameters.CdrhScanAngle240 CdrhScanAngle240 => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.CdrhScanAngle240] as Parameters.CdrhScanAngle240;

		public Parameters.CycleTime CycleTime => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.CycleTime] as Parameters.CycleTime;

		public Parameters.EcgScanPhaseDelay EcgScanPhaseDelay => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.EcgScanPhaseDelay] as Parameters.EcgScanPhaseDelay;

		public Parameters.MAs MAs => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.MAs] as Parameters.MAs;

		public Parameters.Pedal Pedal => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.Pedal] as Parameters.Pedal;

		public Parameters.PedalMode PedalMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.PedalMode] as Parameters.PedalMode;

		public Parameters.RequestedCycleTime RequestedCycleTime => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RequestedCycleTime] as Parameters.RequestedCycleTime;

		public Parameters.RotationsPerScan RotationsPerScan => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.RotationsPerScan] as Parameters.RotationsPerScan;

		public Parameters.ScanAngle ScanAngle => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.ScanAngle] as Parameters.ScanAngle;

		public Parameters.SliceIncrement SliceIncrement => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.SliceIncrement] as Parameters.SliceIncrement;

		public Parameters.StartAngle StartAngle => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.StartAngle] as Parameters.StartAngle;

		public Parameters.UseStartAngle UseStartAngle => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.StepParameters.UseStartAngle] as Parameters.UseStartAngle;

	}

}
