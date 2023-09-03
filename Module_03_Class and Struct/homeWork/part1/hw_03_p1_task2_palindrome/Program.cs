// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #3: Структуры. Классы. Свойства
// Домашнее задание
// Часть #1

// Задание #2.
// Напишите метод, который проверяет является ли переданное число «палиндромом».
// Число передаётся в качестве параметра. Если число палиндром нужно вернуть из метода true, иначе false.

using System.Text;

namespace hw_03_p1_task2_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valueInt = GetConsoleInput("Please enter at least 2-digits value", 10);
            Console.WriteLine(valueInt + (IsPalindrome(valueInt) ? " is" : " is not") + " palindrome");
        }

        static bool IsPalindrome(int? value)
        {
            if (value is null)
            {
                return false;
            }
            string valueStr = $"{value}";
            StringBuilder valueSB = new StringBuilder(valueStr);

            for (int i = 0; i < valueSB.Length / 2; i++)
            {
                (valueSB[i], valueSB[valueSB.Length - i - 1]) = (valueSB[valueSB.Length - i - 1], valueSB[i]);
            }

            return valueStr == valueSB.ToString() ? true : false;
        }

        static int GetConsoleInput(string requestText, int startRange = int.MinValue, int endRange = int.MaxValue)
        {
            if (startRange > endRange)
                (startRange, endRange) = (endRange, startRange);

            int? value = null;

            while (value is null)
            {
                Console.WriteLine(requestText);
                try
                {
                    value = int.Parse(Console.ReadLine() ?? "");
                }
                catch (Exception exc)
                {
                    Console.WriteLine($"{exc.Message} Please enter integer value");
                }

                if (value < startRange || value > endRange) 
                {
                    Console.WriteLine($"value {value} is out of {startRange}...{endRange} range");
                    value = null;
                }
            }
            return (int)value;
        }
    }
}