// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// Практическое задание

// Задание 3
// Пользователь с клавиатуры вводит шестизначное число. 
// Необходимо перевернуть число и отобразить результат. 
// Например, если введено 341256, результат 652143.

namespace pw_01_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valueStr = GetConsoleInput("Please enter 6-digits value", 100000, 999999).ToString();
            PrintConsoleReverse(valueStr);
        }

        public static int GetConsoleInput(string requestText, int startRange, int endRange)
        {
            int value;
            do
            {
                Console.WriteLine(requestText);
                while (!int.TryParse(Console.ReadLine(),out value))
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

        static void PrintConsoleReverse(string str)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
        }
    }
}