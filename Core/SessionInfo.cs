using System.Collections.Generic;
using CoreHelper;

namespace Core
{


    public interface ISessionInfo
    {
        IDictionary<IRootObject, IDictionary<string, IRuleInfo>> SessionData { get; }

        //IList<IRootObject> RootObjects { get; }

        IExternalDecisionProvider Edp { get; }

        ExecutionMode ExecutionMode { get; }

        //IDictionary<string, IRuleInfo> RuleInfos { get; }

        IExitStrategyInputData ExitStrategyInputData { get; }

    }

    public class SessionInfo : ISessionInfo
    {
        public SessionInfo(IDictionary<IRootObject, IDictionary<string, IRuleInfo>> sessionData, IExternalDecisionProvider edp, ExecutionMode executionMode, IExitStrategyInputData exitStategyData)
        {
            SessionData = sessionData;
            Edp = edp;
            ExecutionMode = executionMode;
            ExitStrategyInputData = exitStategyData;
        }


        public IExternalDecisionProvider Edp { get; }

        public ExecutionMode ExecutionMode { get; }

        public IExitStrategyInputData ExitStrategyInputData { get; }

        public IDictionary<IRootObject, IDictionary<string, IRuleInfo>> SessionData { get; }
    }
}