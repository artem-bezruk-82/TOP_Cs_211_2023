// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// ДОМАШНЕЕ ЗАДАНИЕ

// Задание 7
// Пользователь вводит с клавиатуры два числа.
// Нужно показать все четные числа в указанном диапазоне.
// Если границы диапазона указаны неправильно требуется произвести нормализацию границ.
// Например, пользователь ввел 20 и 11, требуется нормализация, после которой начало диапазона станет равно 11, а конец 20.

namespace hw_01_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rangeStart = GetConsoleInput("Please enter start range value");
            int rangeEnd = GetConsoleInput("Please enter end range value");

            PrintEvenNumbersInrange(rangeStart, rangeEnd);
        }

        static void PrintEvenNumbersInrange(int rangeStart, int rangeEnd) 
        {
            if (rangeStart > rangeEnd)
                (rangeStart, rangeEnd) = (rangeEnd, rangeStart);

            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                if ((i % 2 == 0) && (i != 0))
                    Console.Write($" {i}");
            }
        }

        static int GetConsoleInput(string requestText)
        {
            int? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = int.Parse(Console.ReadLine() ?? string.Empty);
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"{exc.Message} Please enter {typeof(int)} value");
                }
            }
            return (int)value;
        }
    }
}