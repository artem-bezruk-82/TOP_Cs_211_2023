// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// ДОМАШНЕЕ ЗАДАНИЕ

// Задание 3
// Пользователь вводит с клавиатуры четыре цифры.
// Необходимо создать число, содержащее эти цифры.
// Например, если с клавиатуры введено 1, 5, 7, 8 тогда нужно сформировать число 1578.

namespace hw_01_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Our program receives 4 digits from user via console and returns 4-digints number");

            do
            {
                Console.WriteLine($"\nEntered value is {GetValueConsole(4)}");
            }
            while (EndProgram("Would you like to start new calculation?"));

            Console.WriteLine("\nThank you for using our program! Goodby");
        }

        public static int GetValueConsole(int numberOfDigits) 
        {
            numberOfDigits = Math.Abs(numberOfDigits);
            char[] digits = new char[numberOfDigits];
            int? value = null;
            while (value == null) 
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    Console.WriteLine($"\nPlease enter digit # {i}");
                    digits[i] = Console.ReadKey().KeyChar;
                }

                try
                {
                    value = Convert.ToInt32(new string(digits));
                }
                catch (Exception exc) 
                {
                    Console.WriteLine($"\n{exc.Message} You supposed to enter digits only.");
                }
            }
            return (int)value;
        }

        public static bool EndProgram(string requestText)
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