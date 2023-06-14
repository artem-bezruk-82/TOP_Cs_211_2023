// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #1: Введение в платформу Microsoft .NET. Типы данных. Операторы.
// Домашнее задание

// Задание #2.
// Даны целые положительные числа A, B, C.
// Начальный вклад в банке равен 10000 руб.
// Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25).
// Значение Р программа должна получать у пользователя.
// По данному P определить через сколько месяцев размер вклада превысит 11000 руб.
// Вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число)

using System;

namespace material_01_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to our deposite calculator!");
            while (EndProgram("Would you like new calculation?"))
            {
                int initialDeposite = 10000;
                int targetDeposite = 11000;
                double finalDeposite = initialDeposite;
                int monthlyRateMin = 0;
                int monthlyRateMax = 25;
                int monthlyRate = GetConsoleInputInt($"\nPlease enter desireble monthly rate " +
                    $"within {monthlyRateMin}...{monthlyRateMax} range", monthlyRateMin, monthlyRateMax);
                int months = 0;

                if (monthlyRate > 0)
                {
                    while (finalDeposite < targetDeposite)
                    {

                        finalDeposite *= (100 + (double)monthlyRate) / 100;
                        months++;
                    }
                    Console.WriteLine($"Initial deposite: {initialDeposite} with monthly rate {monthlyRate} " +
                        $"will achieve {targetDeposite} value within {months} months");
                }
                else
                {
                    Console.WriteLine("Deposite will never achieve tatget value due to zero monthly rate");
                }
            }

            Console.WriteLine("\nThank you for using our program. Goodbye!");
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

        static bool EndProgram(string requestText)
        {
            Console.WriteLine($"\n{requestText}, Yes(y), No(n)");
            char key = Console.ReadKey().KeyChar;
            while (key != 'n' && key != 'y')
            {
                Console.WriteLine("\nThe only 'y' or 'n' are required");
                key = Console.ReadKey().KeyChar;
            }
            if (key == 'y')
            {
                return true;
            }
            return false;
        }
    }
}