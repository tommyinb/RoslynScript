using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynScript.Utility
{
    public static class ConsoleUtil
    {
        public static void Write(ConsoleColor color, object value)
        {
            using (new ConsoleHighlight(color))
            {
                Console.Write(value);
            }
        }
        public static void WriteLine(ConsoleColor color, object value)
        {
            using (new ConsoleHighlight(color))
            {
                Console.WriteLine(value);
            }
        }
    }
}
