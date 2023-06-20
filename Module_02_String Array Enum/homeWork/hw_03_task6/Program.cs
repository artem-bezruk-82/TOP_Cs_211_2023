// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 2
// Тема: Массивы. Cтроки. Перечисления
// ДОМАШНЕЕ ЗАДАНИЕ

//Задание 6
//Пользователь с клавиатуры вводит некоторый текст. 
//Приложение должно изменять регистр первой буквы каждого предложения на букву в верхнем регистре.
//Например, если пользователь ввёл: «today is a good day for walking. i will try to walk near the sea».
//Результат работы приложения: «Today is a good day for walking. I will try to walk near the sea».

using System.Text;

namespace hw_03_task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = "today is a good day for walking. i will try to walk near the sea.";

            Console.WriteLine(inputText);

            string[] sentetces = inputText.Trim().Split('.', StringSplitOptions.RemoveEmptyEntries);

            StringBuilder outputTextSb = new StringBuilder();

            for (int i = 0; i < sentetces.Length; i++)
            {
                StringBuilder sb = new StringBuilder(sentetces[i].Trim());
                sb[0] = char.ToUpper(sb[0]);
                outputTextSb.Append($"{sb}. ");
            }

            string outputText = outputTextSb.ToString();

            Console.WriteLine(outputText.Trim());
        }
    }
}