using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Patterns.StrategyPattern
{
    public static class Strategies
    {
        public static int Sum(List<int> list) { return list.Sum(); }

        public static int Max(List<int> list) { return list.Max(); }

        public static int CountEven(List<int> list)
        {
            return list.Count(IsEven);
        }
        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
