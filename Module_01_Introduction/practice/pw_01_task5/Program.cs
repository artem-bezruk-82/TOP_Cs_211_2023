// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// Практическое задание

// Задание 5
// Даны целые положительные числа A и B (A < B).
// Вывести все целые числа от A до B включительно:
// - каждое число должно выводиться на новой строке;
// - каждое число должно выводиться количество раз, равное его значению.

namespace pw_01_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintValues(3,7);
        }

        static void PrintValues(int startRange, int endRange) 
        {
            if (startRange > endRange)
            {
                (startRange, endRange) = (endRange, startRange);
            }

            for (int i = startRange; i <= endRange; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine();
            }
        }
    }
}