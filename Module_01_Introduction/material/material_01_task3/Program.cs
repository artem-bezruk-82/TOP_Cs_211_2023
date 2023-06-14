// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #1: Введение в платформу Microsoft .NET. Типы данных. Операторы.
// Домашнее задание

// Задание #3
// Даны целые положительные числа A и B (A < B).
// Вывести все целые числа от A до B включительно; каждое  число должно выводиться на новой строке;
// при этом  каждое число должно выводиться количество раз, равное его значению
// (например, число 3 выводится 3 раза). 

namespace material_01_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startValue = GetConsoleInputInt(requestText: "Please enter start value", startRange: 0);
            int endValue = GetConsoleInputInt(requestText: "Please enter end value", 
                startRange: startValue + 1);

            for (int i = startValue; i <= endValue; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }

        }

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