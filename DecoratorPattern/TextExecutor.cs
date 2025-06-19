using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Patterns.DecoratorPattern
{
    public static class TextExecutor
    {
        public static string Execute(Func<string, string> processor, string input)
        {
            Console.WriteLine("-> Start text processing...");

            Stopwatch sw = Stopwatch.StartNew();
            string result;

            try
            {
                result = processor(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"!!! Error: {ex.Message}");
                return "[Processing error]";
            }

            sw.Stop();
            Console.WriteLine($"-> Processing completed.");

            return result;
        }
    }
}
