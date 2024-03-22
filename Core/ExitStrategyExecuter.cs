using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Core
{
    interface IExitStrategyExecutor
    {
        bool HaltExecution { get; set; }

        void ProcessData(string ruleName);

        void ResetOnSuccessfulExecution();
    }

    internal class ExitStrategyExecutor: IExitStrategyExecutor
    {
        public ExitStrategyExecutor(IList<IExitStrategy> exitStrategiesData)
        {
            exitStrategies = exitStrategiesData;
            SubscribeEvent();
        }


        public bool HaltExecution { get; set; }

        public void ProcessData(string ruleName)
        {
            allRules.Add(ruleName);
            foreach (var strategy in exitStrategies)
            {
                Task.Run(()=>strategy.ProcessData(ruleName,allRules), cts.Token);
            }
        }

        public void ResetOnSuccessfulExecution()
        {
            ResetStopExecution();
        }

        private void SubscribeEvent()
        {
            foreach (var strategy in exitStrategies)
            {
                strategy.Exit += OnExit;
            }
        }

        private void OnExit(object sender, EventArgs e)
        {
            ResetStopExecution();
        }

        private void ResetStopExecution()
        {
            cts.Cancel();
            allRules.Clear();
            HaltExecution = true;
            foreach (var strategy in exitStrategies)
            {
                strategy.Reset();
            }
        }

        private readonly List<string> allRules = new List<string>();
        private readonly CancellationTokenSource cts = new CancellationTokenSource();
        private readonly IList<IExitStrategy> exitStrategies;
    }
}