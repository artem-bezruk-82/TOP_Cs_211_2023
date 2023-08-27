// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок 2: Массивы, строки, перечисления
// Методический материал

// Упражнение 3
// Написать программу, которая предлагает пользователю ввести число и
// считает, сколько раз это число встречается в массиве.

namespace ex_02_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 8, 7, 6, 5, 4, 3, 2, 1};
            int value = GetConsoleInput("Please enter value");
            Console.WriteLine($"Value {value} appeared {CountValue(myArray, value)} times");
        }

        static int CountValue(int[] array, int value) 
        {
            int count = 0;
            foreach (int element in array) 
            {
                if (element == value)
                {
                    count++;
                }
            }
            return count;
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