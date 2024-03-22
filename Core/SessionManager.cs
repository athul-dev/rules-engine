using System;
using System.Collections.Generic;
using System.Linq;
using CoreHelper;

namespace Core
{
    public interface ISessionManager
    {
        void AddSessions(ISessionInfo sessionInfo);
        void RemoveSession(Guid stepId);
        void SetCurrentEditedStep(Guid stepId);
        void SetCurrentEditedResult(Guid stepId, Guid resultId);
        IRuleEngineSession GetCurrentSession();
        IRuleEngineSession GetRuleEngineSession(Guid stepId);
        IList<IRuleEngineSession> GetRuleEngineSessions();
    }

    public class SessionManager : ISessionManager
    {
        public SessionManager()
        {
            ruleEngineSessions = new Dictionary<Guid, IRuleEngineSession>();
        }

        public void AddSessions(ISessionInfo sessionInfo)
        {
            foreach (var session in GetSessions(sessionInfo))
            {
                if (CurrentEditedStepId == Guid.Empty)
                {
                    CurrentEditedStepId = session.Key;
                    CurrentEditedResultId = session.Value.GetResultIds().FirstOrDefault();
                }
                ruleEngineSessions[session.Key] = session.Value;
            }
        }

        public void RemoveSession(Guid stepId)
        {
            ruleEngineSessions.Remove(stepId);
        }

        public void SetCurrentEditedStep(Guid stepId)
        {
            CurrentEditedStepId = stepId;
        }

        public void SetCurrentEditedResult(Guid stepId, Guid resultId)
        {
            CurrentEditedResultId = resultId; //TODO to be passed to ExecutionContext
            CurrentEditedStepId = stepId;
        }

        public IRuleEngineSession GetCurrentSession()
        {
            return ruleEngineSessions[CurrentEditedStepId];
        }

        public IRuleEngineSession GetRuleEngineSession(Guid stepId)
        {
            return ruleEngineSessions[stepId];
        }

        public IList<IRuleEngineSession> GetRuleEngineSessions()
        {
            return ruleEngineSessions.Values.ToList();
        }

        #region Private Members

        private IDictionary<Guid, IRuleEngineSession> GetSessions(ISessionInfo sessionInfo)
        {
            IDictionary<Guid, IRuleEngineSession> sessionList = new Dictionary<Guid, IRuleEngineSession>();

            foreach (var kvp in sessionInfo.SessionData)
            {
                IWorkingMemory workingMemory = new WorkingMemory(kvp.Key);

                IRuleEngineSession session = ruleEngineSessionFactory.GetRuleEngineSession(sessionInfo.ExecutionMode, kvp.Value, workingMemory, sessionInfo.Edp, ruleCompositionHelper, sessionInfo.ExitStrategyInputData);

                sessionList.Add(kvp.Key.CurrentStepId, session);
            }

            return sessionList;
        }

       

        private readonly IDictionary<Guid, IRuleEngineSession> ruleEngineSessions;
        private Guid CurrentEditedStepId { get; set; }
        private Guid CurrentEditedResultId { get; set; }
        private readonly IRuleCompositionHelper ruleCompositionHelper = new RuleCompositionHelper();
        private readonly IRuleEngineSessionFactory ruleEngineSessionFactory = new RuleEngineSessionFactory();

        #endregion

    }
}
