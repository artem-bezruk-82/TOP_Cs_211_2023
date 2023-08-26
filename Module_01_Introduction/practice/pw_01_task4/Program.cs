// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// Практическое задание

// Задание 4
// Пользователь вводит с клавиатуры границы числового диапазона.
// Требуется показать все числа Фибоначчи из этого диапазона. Числа Фибоначчи — элементы числовой 


using System.Text;

namespace pw_01_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = GetConsoleInput($"Please enter start range value", 0);
            int end = GetConsoleInput($"Please enter start range value", 0);
            Console.WriteLine(GetFibonacciValueStr(start, end));
        }

        public static string GetFibonacciValueStr(int positionStart, int positionEnd)
        {
            StringBuilder sb = new StringBuilder();
           

            if (positionStart > positionEnd) 
            {
                (positionStart, positionEnd) = (positionEnd, positionStart);
            }

            if (positionEnd > 1)
            {
                long minusTwo = 0;
                long minusOne = 1;
                long fibonacciValue = 0;

                for (int i = 1; i < positionEnd; i++)
                {
                    fibonacciValue = minusOne + minusTwo;
                    minusOne = minusTwo;
                    minusTwo = fibonacciValue;
                    if (i > positionStart)
                    {
                        sb.Append($", {fibonacciValue}");
                    }
                }
            }
            else 
            {
                sb.Append(0);
            }
            return sb.ToString();
        }

        public static int GetConsoleInput(string requestText, int startRange = int.MinValue, 
            int endRange = int.MaxValue)
        {
            int value;
            do
            {
                Console.WriteLine(requestText);
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"Entered value is not {typeof(int)}. {requestText}");
                }
                if (value < startRange || value > endRange)
                {
                    Console.WriteLine($"Entered value is out of {startRange}...{endRange} range. {requestText}");
                }
            } while (value < startRange || value > endRange);
            return value;
        }
    }
}