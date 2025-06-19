using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Patterns.StrategyPattern
{
    public class StrategyContext
    {
        private Func<List<int>, int> _strategy;

        public StrategyContext(Func<List<int>, int> strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(Func<List<int>, int> strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteAroundStrategy(List<int> data)
        {
            Console.WriteLine("-> Starting strategy...");

            int result;

            try
            {
                result = _strategy(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"!!! Error: {ex.Message}");
                return -1;
            }

            Console.WriteLine("-> Execution completed successfully.");
            return result;
        }
    }
}
