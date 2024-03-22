using System;
using System.Collections.Generic;
using System.Timers;
using CoreHelper;

namespace Core
{
    [Flags]
    public enum ExitStrategyFlag
    {
        MaxTimerStrategy,

        MaxRulesStrategy,

        MaxIndividualRulesStrategy,

        LoopDetectionStrategy
    }


    interface IExitStrategy
    {
        void ProcessData(string ruleNode, List<string> allRules);

        event EventHandler Exit;

        void Reset();
    }


    public interface IExitStrategyInputData
    {
        ExitStrategyFlag ExitStrategy { get; }

        int MaxNumberOfRules { get; }

        long MaxTime { get; }

        int MaxNumberOfIndividualRules { get; }

        int MaxNumberOfLoops { get; }
    }


    public class ExitStrategyInputData : IExitStrategyInputData
    {
        public ExitStrategyInputData(ExitStrategyFlag exitStrategyFlag = ExitStrategyFlag.MaxRulesStrategy | ExitStrategyFlag.MaxTimerStrategy,
            int maxNumberOfRules = 10000, long maxTimer = 30000, int maxNumberOfIndividualRules = 20, int maxLoopCount = 5)
        {
            ExitStrategy = exitStrategyFlag;
            MaxNumberOfRules = maxNumberOfRules;
            MaxTime = maxTimer;
            MaxNumberOfIndividualRules = maxNumberOfIndividualRules;
            MaxNumberOfLoops = maxLoopCount;
        }

        public ExitStrategyFlag ExitStrategy { get; }

        public int MaxNumberOfRules { get; }

        public long MaxTime { get; }

        public int MaxNumberOfIndividualRules { get; }

        public int MaxNumberOfLoops { get; }
    }


    interface IExitStrategyFactory
    {
        IList<IExitStrategy> GetExitStrategy(IExitStrategyInputData exitStrategyInputData);
    }

    internal class ExitStrategyFactory: IExitStrategyFactory
    {
        public IList<IExitStrategy> GetExitStrategy(IExitStrategyInputData exitStrategyInputData)
        {
            IList<IExitStrategy> selectedExitStrategies = new List<IExitStrategy>();

            if (exitStrategyInputData.ExitStrategy.HasFlag(ExitStrategyFlag.MaxTimerStrategy))
            {
                selectedExitStrategies.Add(new MaxTimerStrategy(exitStrategyInputData.MaxTime));
            }
            if (exitStrategyInputData.ExitStrategy.HasFlag(ExitStrategyFlag.MaxRulesStrategy))
            {
                selectedExitStrategies.Add(new MaxRulesStrategy(exitStrategyInputData.MaxNumberOfRules));
            }
            if (exitStrategyInputData.ExitStrategy.HasFlag(ExitStrategyFlag.MaxIndividualRulesStrategy))
            {
                selectedExitStrategies.Add(new MaxIndividualRulesStrategy(exitStrategyInputData.MaxNumberOfIndividualRules));
            }
            if (exitStrategyInputData.ExitStrategy.HasFlag(ExitStrategyFlag.LoopDetectionStrategy))
            {
                selectedExitStrategies.Add(new LoopDetectionStrategy(exitStrategyInputData.MaxNumberOfLoops));
            }

            return selectedExitStrategies;
        }

    }


    internal class MaxTimerStrategy : IExitStrategy
    {
        public event EventHandler Exit;

        public MaxTimerStrategy(long maxTime)
        {
            maxTimer = maxTime;
        }
        
        public void ProcessData(string ruleNodes, List<string> allRules)
        {
            if (allRules.Count > 1 && timer == null)
            {
                timer = new Timer(maxTimer);
                timer.Elapsed += Timer_Elapsed;
                timer.Start();
            }
        }

        public void Reset()
        {
            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
                timer = null;
            }
            
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            OnLoopDetect();
        }

        private void OnLoopDetect()
        {
            RulesLogger.Instance.Log("Loop Detected from Max Timer Strategy");
            Exit?.Invoke(this, new EventArgs());
        }

        private readonly long maxTimer;

        private Timer timer;
    }


    internal class MaxRulesStrategy : IExitStrategy
    {
        public event EventHandler Exit;

        public MaxRulesStrategy(int maxNumberOfRules)
        {
            maxRules = maxNumberOfRules;
        }
        
        public void ProcessData(string ruleNodes, List<string> allRules)
        {
            if (allRules.Count > maxRules)
            {
                OnLoopDetect();
            }
        }

        public void Reset()
        {
        }

        private void OnLoopDetect()
        {
            RulesLogger.Instance.Log("Loop Detected from Max Rules Strategy");
            Exit?.Invoke(this, new EventArgs());
        }

        private readonly int maxRules;
    }


    internal class MaxIndividualRulesStrategy : IExitStrategy
    {
        public event EventHandler Exit;

        public MaxIndividualRulesStrategy(int maxIndividualRules)
        {
            maxIndividualRulesAllowed = maxIndividualRules;
            counterDictionary = new Dictionary<string, int>();
        }
        
        public void ProcessData(string ruleNodes, List<string> allRules)
        {
            if (!counterDictionary.ContainsKey(ruleNodes))
            {
                counterDictionary.Add(ruleNodes, 1);
            }
            else
            {
                counterDictionary[ruleNodes] = counterDictionary[ruleNodes] + 1;
                if (counterDictionary[ruleNodes] > maxIndividualRulesAllowed)
                {
                    OnLoopDetect();
                }
            }
        }

        public void Reset()
        {
            counterDictionary.Clear();
        }

        private void OnLoopDetect()
        {
            RulesLogger.Instance.Log("Loop Detected from Max Number of Individual Rules Strategy");
            Exit?.Invoke(this, new EventArgs());
        }

        private readonly int maxIndividualRulesAllowed;

        private readonly Dictionary<string, int> counterDictionary;
    }


    internal class LoopDetectionStrategy :  IExitStrategy
    {
        public event EventHandler Exit;

        public LoopDetectionStrategy(int maxNumberOfLoops)
        {
            maxLoops = maxNumberOfLoops;
            patternMatchDictionary = new Dictionary<string, int>();
        }

        public void ProcessData(string ruleNodes, List<string> allRules)
        {
            if (allRules.Contains(ruleNodes))
            {
                int i = allRules.IndexOf(ruleNodes);

                string key = string.Empty;

                for (int j = i; j < allRules.Count; j++)
                {
                    key += allRules[j];
                }


                for (int j = allRules.Count - 1; j >= i; j--)
                {
                    allRules.RemoveAt(j);
                }

                if (!patternMatchDictionary.ContainsKey(key))
                {
                    patternMatchDictionary[key] = 0;
                }
                patternMatchDictionary[key]++;

                if (patternMatchDictionary[key] >= maxLoops)
                {
                    OnLoopDetect();
                }
            }
        }

        public void Reset()
        {
            patternMatchDictionary.Clear();
        }

        private void OnLoopDetect()
        {
            RulesLogger.Instance.Log("Loop Detected from Loop pattern Detect Strategy");
            Exit?.Invoke(this, new EventArgs());
        }

        private readonly int maxLoops;

        private readonly IDictionary<string, int> patternMatchDictionary;
    }
}
