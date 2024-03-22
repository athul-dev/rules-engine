namespace RootObject
{

	public interface IResultRootObject:CoreHelper.IItem
	{

		Parameters.CenterXmm CenterXmm { get; }

		Parameters.CenterYmm CenterYmm { get; }

		Parameters.ContinuePreviousSeries ContinuePreviousSeries { get; }

		Parameters.DefaultStorage DefaultStorage { get; }

		Parameters.Enhancement Enhancement { get; }

		Parameters.ImageColumns ImageColumns { get; }

		Parameters.ImageMatrix ImageMatrix { get; }

		Parameters.ImageRows ImageRows { get; }

		Parameters.ImagesPerScan ImagesPerScan { get; }

		Parameters.IrsStage IrsStage { get; }

		Parameters.IrsSubStage IrsSubStage { get; }

		Parameters.JogNSlices JogNSlices { get; }

		Parameters.MprBodyPart MprBodyPart { get; }

		Parameters.MprCenterXmm MprCenterXmm { get; }

		Parameters.MprCenterYmm MprCenterYmm { get; }

		Parameters.MprEndPosition MprEndPosition { get; }

		Parameters.MprFieldOfViewX MprFieldOfViewX { get; }

		Parameters.MprFieldOfViewY MprFieldOfViewY { get; }

		Parameters.MprFilming MprFilming { get; }

		Parameters.MprFirstImage MprFirstImage { get; }

		Parameters.MprIncrement MprIncrement { get; }

		Parameters.MprIncrementUI MprIncrementUI { get; }

		Parameters.MprLength MprLength { get; }

		Parameters.MprMiddleImage MprMiddleImage { get; }

		Parameters.MprNSlices MprNSlices { get; }

		Parameters.MprRenderingMode MprRenderingMode { get; }

		Parameters.MprThickness MprThickness { get; }

		Parameters.ReconFirstImage ReconFirstImage { get; }

		Parameters.ReconLength ReconLength { get; }

		Parameters.Reconstruction Reconstruction { get; }

		Parameters.ReconstructionUI ReconstructionUI { get; }

		Parameters.ReconThickness ReconThickness { get; }

		Parameters.ReferenceNoise ReferenceNoise { get; }

		Parameters.ResultPriority ResultPriority { get; }

		Parameters.SpectralResult SpectralResult { get; }

		Parameters.SpectralResultAssociatedValue SpectralResultAssociatedValue { get; }

		Parameters.WindowCenter WindowCenter { get; }

		Parameters.WindowPreset WindowPreset { get; }

		Parameters.WindowWidth WindowWidth { get; }

	}

	public abstract class ResultRootObject :CoreHelper.Item, IResultRootObject
	{

		protected ResultRootObject(System.Guid id) : base(id) {}

		public Parameters.CenterXmm CenterXmm => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CenterXmm] as Parameters.CenterXmm;

		public Parameters.CenterYmm CenterYmm => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.CenterYmm] as Parameters.CenterYmm;

		public Parameters.ContinuePreviousSeries ContinuePreviousSeries => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ContinuePreviousSeries] as Parameters.ContinuePreviousSeries;

		public Parameters.DefaultStorage DefaultStorage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.DefaultStorage] as Parameters.DefaultStorage;

		public Parameters.Enhancement Enhancement => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Enhancement] as Parameters.Enhancement;

		public Parameters.ImageColumns ImageColumns => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageColumns] as Parameters.ImageColumns;

		public Parameters.ImageMatrix ImageMatrix => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageMatrix] as Parameters.ImageMatrix;

		public Parameters.ImageRows ImageRows => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImageRows] as Parameters.ImageRows;

		public Parameters.ImagesPerScan ImagesPerScan => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ImagesPerScan] as Parameters.ImagesPerScan;

		public Parameters.IrsStage IrsStage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IrsStage] as Parameters.IrsStage;

		public Parameters.IrsSubStage IrsSubStage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.IrsSubStage] as Parameters.IrsSubStage;

		public Parameters.JogNSlices JogNSlices => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.JogNSlices] as Parameters.JogNSlices;

		public Parameters.MprBodyPart MprBodyPart => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprBodyPart] as Parameters.MprBodyPart;

		public Parameters.MprCenterXmm MprCenterXmm => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprCenterXmm] as Parameters.MprCenterXmm;

		public Parameters.MprCenterYmm MprCenterYmm => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprCenterYmm] as Parameters.MprCenterYmm;

		public Parameters.MprEndPosition MprEndPosition => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprEndPosition] as Parameters.MprEndPosition;

		public Parameters.MprFieldOfViewX MprFieldOfViewX => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFieldOfViewX] as Parameters.MprFieldOfViewX;

		public Parameters.MprFieldOfViewY MprFieldOfViewY => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFieldOfViewY] as Parameters.MprFieldOfViewY;

		public Parameters.MprFilming MprFilming => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFilming] as Parameters.MprFilming;

		public Parameters.MprFirstImage MprFirstImage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprFirstImage] as Parameters.MprFirstImage;

		public Parameters.MprIncrement MprIncrement => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprIncrement] as Parameters.MprIncrement;

		public Parameters.MprIncrementUI MprIncrementUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprIncrementUI] as Parameters.MprIncrementUI;

		public Parameters.MprLength MprLength => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprLength] as Parameters.MprLength;

		public Parameters.MprMiddleImage MprMiddleImage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprMiddleImage] as Parameters.MprMiddleImage;

		public Parameters.MprNSlices MprNSlices => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprNSlices] as Parameters.MprNSlices;

		public Parameters.MprRenderingMode MprRenderingMode => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprRenderingMode] as Parameters.MprRenderingMode;

		public Parameters.MprThickness MprThickness => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.MprThickness] as Parameters.MprThickness;

		public Parameters.ReconFirstImage ReconFirstImage => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconFirstImage] as Parameters.ReconFirstImage;

		public Parameters.ReconLength ReconLength => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconLength] as Parameters.ReconLength;

		public Parameters.Reconstruction Reconstruction => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.Reconstruction] as Parameters.Reconstruction;

		public Parameters.ReconstructionUI ReconstructionUI => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconstructionUI] as Parameters.ReconstructionUI;

		public Parameters.ReconThickness ReconThickness => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ReconParameters.ReconThickness] as Parameters.ReconThickness;

		public Parameters.ReferenceNoise ReferenceNoise => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ReferenceNoise] as Parameters.ReferenceNoise;

		public Parameters.ResultPriority ResultPriority => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.ResultPriority] as Parameters.ResultPriority;

		public Parameters.SpectralResult SpectralResult => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.SpectralResult] as Parameters.SpectralResult;

		public Parameters.SpectralResultAssociatedValue SpectralResultAssociatedValue => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.SpectralResultAssociatedValue] as Parameters.SpectralResultAssociatedValue;

		public Parameters.WindowCenter WindowCenter => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowCenter] as Parameters.WindowCenter;

		public Parameters.WindowPreset WindowPreset => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowPreset] as Parameters.WindowPreset;

		public Parameters.WindowWidth WindowWidth => FactCollection[Philips.PmsCT.Host.Framework.ExamRecordInternalInterfaces.ResultParameters.WindowWidth] as Parameters.WindowWidth;

	}

}
