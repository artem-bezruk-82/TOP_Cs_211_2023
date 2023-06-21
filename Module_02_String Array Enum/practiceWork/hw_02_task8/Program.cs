// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 8
// Пользователь вводит с клавиатуры предложение.
// Приложение должно посчитать количество гласных букв в нём

namespace hw_02_task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            string userInput = "Hello, World!";
            int numOfVowels = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                if (Array.Exists(vowels, element => element == userInput[i]))
                {
                    numOfVowels++;
                }
            }

            Console.WriteLine($"{userInput}\nVowels: {numOfVowels}");
        }
    }
}