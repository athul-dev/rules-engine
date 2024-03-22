using System;

namespace CoreHelper
{
    public class RulesLogger
    {
        private bool canLog = false;

        private RulesLogger()
        {

        }

        public static RulesLogger Instance => new RulesLogger();

        public void Log(string str)
        {
            if (!canLog)
            {
                return;
            }
            Console.WriteLine(str);
        }
    }
}
