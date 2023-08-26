using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pw_01_task6
{
    static class DirectionsEnumExt
    {
        public static void PrintConsole()
        {
            var types = Enum.GetValues(typeof(DirectionsEnum));
            foreach (var type in types)
            {
                Console.WriteLine($"\t{(int)type} - {type}");
            }
        }

        public static DirectionsEnum GetDirectionConsole() 
        {
            int? index = null;
            do 
            {
                Console.WriteLine("Please chose line direction");
                PrintConsole();
                index = ConsoleInputHandling.GetConsoleInput("Please chose line direction", 1 , 
                    Enum.GetNames(typeof(DirectionsEnum)).Length);
                if (!Enum.IsDefined(typeof(DirectionsEnum), (DirectionsEnum)index)) 
                {
                    index = null;
                }
            }
            while (index == null);

            return (DirectionsEnum)index;
        }
    }
}
