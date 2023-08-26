// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// Практическое задание

// Задание 6
// Пользователь с клавиатуры вводит:
// длину линии, символ заполнитель, направление линии (горизонтальная, вертикальная).
// Программа отображает линию по заданным параметрам.
// Например: +++++.
// Параметры линии: горизонтальная линия, длина равна пяти, символ заполнитель +.

namespace pw_01_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter symbol to draw");
            char symbol = Console.ReadKey().KeyChar;

            int length = ConsoleInputHandling.GetConsoleInput("Please enter line length to draw", 0);

            DirectionsEnum direction = DirectionsEnumExt.GetDirectionConsole();

            Draw(symbol, length, direction);

        }

        static void Draw(char symbol, int length, DirectionsEnum direction)
        {
            switch (direction)
            {
                case DirectionsEnum.Vertical:
                    DrawVertical(symbol, length);
                    break;
                case DirectionsEnum.Horisontal:
                    DrawHorizontal(symbol, length);
                    break;
                case DirectionsEnum.Diagonal:
                    DrawDiagonal(symbol, length);
                    break;
            }
        }

        static void DrawVertical(char symbol, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(symbol);
            }
            Console.WriteLine();
        }

        static void DrawHorizontal(char symbol, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }

        static void DrawDiagonal(char symbol, int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {

                    Console.Write(i == j ? symbol : ' ');

                }
                Console.WriteLine();
            }
        }


    }
}