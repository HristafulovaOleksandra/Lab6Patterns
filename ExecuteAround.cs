using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Patterns
{
    public static class ExecuteAround
    {
        public static void WithFile(string path, Action<StreamWriter> action)
        {
            using var writer = new StreamWriter(path);
            writer.WriteLine("______________|Start|______________");
            action(writer);
            writer.WriteLine("______________|End|______________");
        }
    }
}
