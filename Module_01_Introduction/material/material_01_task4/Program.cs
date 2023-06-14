// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #1: Введение в платформу Microsoft .NET. Типы данных. Операторы.
// Домашнее задание

// Задание #4
// Дано целое число N большее 0, найти число, полученное при прочтении числа N справа налево.
// Например, если было введено число 345, то программа должна вывести число 543.


namespace material_01_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = GetConsoleInputInt(requestText: "Please enter value", startRange: 0);
            char[] valueArr = value.ToString().ToCharArray();
            for (int i = 0; i < valueArr.Length / 2; i++)
            {
                (valueArr[i], valueArr[valueArr.Length - 1 - i]) =
                    (valueArr[valueArr.Length - 1 - i], valueArr[i]);
            }
            value = Convert.ToInt32(string.Join("", valueArr));
            Console.WriteLine(value);
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