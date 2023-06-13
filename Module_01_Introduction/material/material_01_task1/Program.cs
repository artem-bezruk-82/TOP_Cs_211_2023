// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #1: Введение в платформу Microsoft .NET. Типы данных. Операторы.
// Домашнее задание
// Задание #1.
// Даны целые положительные числа A, B, C.
// Значение этих чисел программа должна запрашивать у пользователя.
// На прямоугольнике размера A*B размещено максимально возможное количество квадратов со стороной C.
// Квадраты не накладываются друг на друга.
// Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника.
// Необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя разместить ни одного
// квадрата со стороной С (например, если значение С превышает размер сторон прямоугольника).


namespace material_01_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = RectangleExt.CreateRectangleConsole();
            Console.WriteLine(rectangle);
            Square square = SquareExt.CreateSquareConsole();
            Console.WriteLine(square);

            if (rectangle.Height >= square.Side || rectangle.Width >= square.Side)
            {
                int squresAlongHeight = rectangle.Height / square.Side;
                int squsresAlongWidth = rectangle.Width / square.Side;
                int numberOfSquares = squresAlongHeight * squsresAlongWidth;
                int uncoveredArea = rectangle.GetArea() - square.GetArea() * numberOfSquares;
                Console.WriteLine($"Number of squeares within the rectangle: {numberOfSquares}");
                Console.WriteLine($"Uncovered Area: {uncoveredArea}");
            }
            else
            {
                Console.WriteLine("Sorry, but the square's size does not fit the rectangle space");
            }
        }
    }
}