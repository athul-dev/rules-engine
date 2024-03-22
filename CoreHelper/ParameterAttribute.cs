using System;

namespace CoreHelper
{
    public enum ERType
    {
        None, 

        Step, 

        Recon,

        Result
    }

    public enum ParameterType
    {
        CTStep,

        SurivewStep,

        RotatingStep,

        AxialStep,

        HelicalStep,

        ResultGeneral,

        SurviewResult,

        RotatingResult,

        AxialResult,

        HelicalResult
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class ParameterAttribute : Attribute
    {
        public string ParameterName { get; }

        public ParameterType ParameterType { get; }

        public Type ParameterDataType { get; }

        public ERType ErType { get; }

        public ParameterAttribute(string parameterName, ParameterType parameterType, Type dataType, ERType  erType)
        {
            ParameterName = parameterName;
            ParameterType = parameterType;
            ParameterDataType = dataType;
            ErType = erType;
        }
    }
}
