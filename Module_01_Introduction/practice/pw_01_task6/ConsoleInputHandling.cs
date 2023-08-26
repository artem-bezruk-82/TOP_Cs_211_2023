using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw_01_task6
{
    internal class ConsoleInputHandling
    {
        public static int GetConsoleInput(string requestText, int startRange = int.MinValue,
            int endRange = int.MaxValue)
        {
            int value;
            do
            {
                Console.WriteLine(requestText);
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"Entered value is not {typeof(int)}. {requestText}");
                }
                if (value < startRange || value > endRange)
                {
                    Console.WriteLine($"Entered value is out of {startRange}...{endRange} range. {requestText}");
                }
            } while (value < startRange || value > endRange);
            return value;
        }
    }
}
