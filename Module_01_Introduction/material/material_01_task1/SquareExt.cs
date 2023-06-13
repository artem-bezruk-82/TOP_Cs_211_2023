using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_01_task1
{
    public static class SquareExt
    {

        public static Square CreateSquareConsole()
        {
            Console.WriteLine("Let's create our square");
            Square square = new Square();
            square.SetUpSquareConsole();
            return square;
        }

        public static void SetUpSquareConsole(this Square square) 
        {
            square.Side = ConsoleInputHandling.GetConsoleInputInt("Please enter side length", 1);
        }
    }
}
