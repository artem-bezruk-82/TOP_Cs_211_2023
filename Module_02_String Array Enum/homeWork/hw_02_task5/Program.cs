// КУРС: ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Модуль 2
// Тема: Массивы. Cтроки. Перечисления
// ДОМАШНЕЕ ЗАДАНИЕ

//Задание 5
// Пользователь с клавиатуры вводит в строку арифметическое выражение.
// Приложение должно посчитать его результат. Необходимо поддерживать только две операции: + и –.

namespace hw_03_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter expression.");
            string expression = Console.ReadLine() ?? string.Empty;
            expression = expression.Trim();
            expression = expression.Replace(" ", "");
            expression = expression.Replace("-", "+-");
            string[] valuesStr = expression.Split("+");
            int result = 0;
            for (int i = 0; i < valuesStr.Length; i++)
            {
                int value;
                if (int.TryParse(valuesStr[i], out value))
                {
                    result += value;
                }
                else 
                {
                    Console.WriteLine(valuesStr[i] + "is not a number and will not be concidered in result");
                }
            }
            Console.WriteLine(result);
        }
    }
}