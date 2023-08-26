// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// Практическое задание

// Задание 2
// Пользователь вводит с клавиатуры пять чисел.
// Необходимо найти сумму чисел, максимум и минимум из пяти чисел, произведение чисел.
// Результат вычислений вывести на экран.

namespace pw_01_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] values = GetValuesConsole(5);
            Console.WriteLine($"[{string.Join(' ', values)}]");
            Console.WriteLine($"Sum: {values.Sum()}; Max: {values.Max()}; Min:{values.Min()}");
        }

        static int[] GetValuesConsole(int numberOfValues) 
        {
            numberOfValues = Math.Abs(numberOfValues);
            int[] values = new int[numberOfValues];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = GetConsoleInput($"\nPlease enter value {i}: ");
            }
            return values;
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