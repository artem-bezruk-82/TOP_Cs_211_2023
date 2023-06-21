// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 9
// Реализуйте приложение для подсчёта количество вхождений подстроки в строку.
// Пользователь вводит исходную строку и слово для поиска. Приложений отображает результат поиска.
// Например:
// пользователь ввёл: Why she had to go. I don't know, she wouldn't say; 
// подстрока для поиска: she;
// результат поиска: 2.

namespace pw_02_task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lookUpWord = "she";

            string inputStringA = "Why she had to go. I don`t know, she wouldn`t say.";
            Console.WriteLine($"{inputStringA}\nWord to lookup: {lookUpWord}");
            Console.WriteLine($"Word {lookUpWord} met {TimesWordMet1(inputStringA, lookUpWord)} times");
            Console.WriteLine($"Word {lookUpWord} met {TimesWordMet2(inputStringA, lookUpWord)} times");
            Console.WriteLine();

            string inputStringB = "She`s going to draw a sheep on a sheet";
            Console.WriteLine($"{inputStringB}\nWord to lookup: {lookUpWord}");
            Console.WriteLine($"Word {lookUpWord} met {TimesWordMet1(inputStringB, lookUpWord)} times");
            Console.WriteLine($"Word {lookUpWord} met {TimesWordMet2(inputStringB, lookUpWord)} times");
        }

        static int TimesWordMet1(string inputString, string word)
        {
            int counter = 0;

            if (inputString.Length > 0)
            {
                inputString = inputString.ToLower();
                int position = 0;
                int index = 0;
                while (index != -1 && position < inputString.Length)
                {
                    index = inputString.IndexOf(word, position);
                    if (index != -1)
                    {
                        counter++;
                    }
                    position = index + word.Length;
                }
            }

            return counter;
        }

        static int TimesWordMet2(string inputString, string word)
        {
            int counter = 0;
            if (inputString.Length > 0)
            {
                inputString = inputString.ToLower();
                char[] charsToTrim = { ' ', '*' };
                char[] delimiters = { ' ', '*', ',', '.', ':', ';', '!', '?', '`' };
                string[] words = inputString.Trim(charsToTrim).Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i] == word)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}