// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 1
// Тема: Введение в платформу Microsoft .NET. Основы языка программирования C#
// Практическое задание

// Задание 1
// Выведите на экран цитату Бьярна Страуструпа:
// It's easy to win forgiveness for being wrong; being right is what gets you into real trouble.
// Пример вывода:
// It's easy to win forgiveness for being wrong; 
// being right is what gets you into real trouble.
// Bjarne Stroustrup

namespace pw_01_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "It's easy to win forgiveness for being wrong;" +
                "being right is what gets you into real trouble." +
                "Bjarne Stroustrup";

            Console.WriteLine($"Intitial string:\n{inputStr}");
            Console.WriteLine();
            Console.WriteLine("Pretty string:");
            PrintStringFormated(inputStr);



            static void PrintStringFormated(string text)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    Console.Write(text[i]);
                    if (text[i] == ';' || text[i] == '.')
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
        }
    }
}