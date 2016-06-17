using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoslynScript.Utility
{
    public class ConsoleHighlight : IDisposable
    {
        public ConsoleHighlight(ConsoleColor color)
        {
            originalColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
        }
        public void Dispose()
        {
            Console.ForegroundColor = originalColor;
        }

        private ConsoleColor originalColor;
    }
}
