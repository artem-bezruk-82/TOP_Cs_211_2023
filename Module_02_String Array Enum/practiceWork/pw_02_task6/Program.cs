// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 6
// Пользователь вводит предложение с клавиатуры. Вам необходимо подсчитать количество слов в нём. 

namespace pw_02_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "  ** Hello  , , ( IT )  World  ! ***  ";
            Console.WriteLine(inputStr);
            char[] trimChar = { ' ', '*', '/' };
            char[] delimiters = { ' ', ',', '.', '?', '!', ':', ';', '*', '(', ')' };
            string[] words = inputStr.Trim(trimChar).Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(' ', words) + ".");
            Console.WriteLine($"Words: {words.Length}");
        }
    }
}