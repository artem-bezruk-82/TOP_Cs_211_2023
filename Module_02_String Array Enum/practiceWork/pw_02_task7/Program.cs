// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 7
// Пользователь вводит предложение с клавиатуры.
// Вам необходимо перевернуть каждое слово предложения и отобразить результат на экран.
// Например: пользователь ввёл: sun cat dogs cup tea; после переворота: nus tac sgod puc aet. 

namespace pw_02_task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInputString = "  sun  cat dogs  cup  tea   ";
            Console.WriteLine(userInputString);
            char[] charsToTrim = { ' ', '*' };
            char[] delimiters = { ' ', '*', ',', '.', ':', ';', '!', '?' };
            string[] words = userInputString.Trim(charsToTrim).Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = StringReverse(words[i]);
                Console.Write($"{words[i]} ");
            }
        }

        static string StringReverse(string str)
        {
            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            return new string(strArray);
        }
    }
}