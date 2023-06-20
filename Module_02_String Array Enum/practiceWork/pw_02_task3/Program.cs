// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 3
// Пользователь вводит с клавиатуры три числа.
// Необходимо подсчитать сколько раз последовательность из этих трёх чисел встречается в массиве. 
// Например:пользователь ввёл: 7 6 5;
// массив: 7 6 5 3 4 7 6 5 8 7 6 5;
// количество повторений последовательности: 3.


using System.Collections.Generic;

namespace pw_02_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] arr = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            Console.WriteLine($"[{string.Join(' ', arr)}]");
            int[] myArr = new int[3];
            FillInArray1DConsole(myArr);
            int[] arrTemp = new int[myArr.Length];

            int startIndex = 0;
            int endIndex = 0;
            int counter = 0;
            while (endIndex < arr.GetUpperBound(0))
            {
                endIndex = startIndex + myArr.GetUpperBound(0);
                Array.ConstrainedCopy(arr, startIndex, arrTemp, 0, arrTemp.Length);
                if (Enumerable.SequenceEqual(myArr, arrTemp))
                {
                    counter++;
                    startIndex += myArr.Length;
                }
                else 
                {
                    startIndex++;
                }
            }
            Console.WriteLine($"[{string.Join(' ', myArr)}] met {counter} times");

        }


        static void FillInArray1DConsole(int[] array)
        {
            Console.WriteLine($"Please fill in 1D array with {typeof(int)} elements");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = GetConsoleInput($"Please enter {i} array element out of {array.Length}");
            }
        }


        static int GetConsoleInput(string requestText)
        {
            int? value = null;

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
            return (int)value;
        }
    }
}