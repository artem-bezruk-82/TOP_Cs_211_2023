// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 2
// Тема: Массивы. Cтроки. Перечисления
// ДОМАШНЕЕ ЗАДАНИЕ

//Задание 3
//Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря.
//Кроме механизма шифровки, реализуйте механизм расшифрования.

using System.Text;

namespace hw_02_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Today is a good day for walking. I will try to walk near the sea.";

            Console.WriteLine(input);

            int caesarShift = 3;

            string encripted = GetCaesarEncriptedString(input, caesarShift);
            Console.WriteLine(encripted);

            string decripted = GetCaesarDecriptedString(encripted, caesarShift);
            Console.WriteLine(decripted);
        }

        static string GetCaesarDecriptedString(string input, int caesarShift)
        {
            int upperCaseStartRange = 65;
            int upperCaseEndRange = 90;
            int lowerCaseStartRange = 97;
            int lowerCaseEndRange = 122;

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int charCode = input[i];
                if (charCode >= upperCaseStartRange && charCode <= upperCaseEndRange)
                {
                    if (charCode - caesarShift < upperCaseStartRange)
                    {
                        output.Append($"{(char)(upperCaseEndRange - (upperCaseStartRange - (charCode - caesarShift) - 1))}");
                    }
                    else
                    {
                        output.Append($"{(char)(charCode - caesarShift)}");
                    }
                }
                else if (charCode >= lowerCaseStartRange && charCode <= lowerCaseEndRange)
                {
                    if (charCode - caesarShift < lowerCaseStartRange)
                    {
                        output.Append($"{(char)(lowerCaseEndRange - (lowerCaseStartRange - (charCode - caesarShift) - 1))}");
                    }
                    else
                    {
                        output.Append($"{(char)(charCode - caesarShift)}");
                    }
                }
                else
                {
                    output.Append(input[i]);
                }
            }

            return output.ToString();
        }

        static string GetCaesarEncriptedString(string input, int caesarShift)
        {
            int upperCaseStartRange = 65;
            int upperCaseEndRange = 90;
            int lowerCaseStartRange = 97;
            int lowerCaseEndRange = 122;

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                int charCode = input[i];
                if (charCode >= upperCaseStartRange && charCode <= upperCaseEndRange)
                {
                    if (charCode + caesarShift > upperCaseEndRange)
                    {
                        output.Append($"{(char)(upperCaseStartRange - (upperCaseEndRange - charCode - caesarShift))}");
                    }
                    else
                    {
                        output.Append($"{(char)(charCode + caesarShift)}");
                    }
                }
                else if (charCode >= lowerCaseStartRange && charCode <= lowerCaseEndRange)
                {
                    if (charCode + caesarShift > lowerCaseEndRange)
                    {
                        output.Append($"{(char)(lowerCaseStartRange - (lowerCaseEndRange - charCode - caesarShift) - 1)}");
                    }
                    else
                    {
                        output.Append($"{(char)(charCode + caesarShift)}");
                    }
                }
                else
                {
                    output.Append(input[i]);
                }
            }

            return output.ToString();
        }

    }
}