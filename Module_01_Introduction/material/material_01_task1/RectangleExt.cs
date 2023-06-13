using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace material_01_task1
{
    public static class RectangleExt
    {
        public static Rectangle CreateRectangleConsole() 
        {
            Console.WriteLine("Let's create out rectangle");
            Rectangle rectangle = new Rectangle();
            rectangle.SetUpRectangleConsole();
            return rectangle;
        } 

        public static void SetUpRectangleConsole(this Rectangle rectangle) 
        {
            rectangle.Width = ConsoleInputHandling.GetConsoleInputInt("Please enter Width", 1);
            rectangle.Height = ConsoleInputHandling.GetConsoleInputInt("Please enter Height", 1);
        }

    }
}
