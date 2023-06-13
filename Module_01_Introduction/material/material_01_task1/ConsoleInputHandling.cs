using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_01_task1
{
    public class ConsoleInputHandling
    {

        public static int GetConsoleInputInt(string requestText, 
            int startRange = int.MinValue, int endRange = int.MaxValue)
        {
            int? value;

            do 
            {
                value = null;
                while (value is null)
                {
                    Console.WriteLine(requestText);
                    try
                    {
                        value = int.Parse(Console.ReadLine() ?? "");
                    }
                    catch (Exception exc)
                    {

                        Console.WriteLine($"{exc.Message} Please enter {typeof(int)} value");
                    }
                }
                if (value < startRange || value > endRange)
                {
                    Console.WriteLine($"Value is out of {startRange}...{endRange} range");
                }
            } while (value < startRange || value > endRange);

            return (int)value;
        }
    }
}
