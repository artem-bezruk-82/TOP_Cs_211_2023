// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 2
// Создайте приложение, отображающее количество значений в массиве меньше заданного параметра пользователем.
// Например, количество значений меньших, чем 7 (7 введено пользователем с клавиатуры). 

namespace pw_02_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 4, 5, 3, 3, 3 };
            int value = 3;
            Console.WriteLine($"There are {LessThanValue(myArray, value)} values less than {value}");


        }


        static int LessThanValue(int[] array, int value)
        {
            Array.Sort(array);
            if (value > array[array.GetUpperBound(0)])
            {
                return array.Length;
            }
            else if (value > array[array.GetLowerBound(0)])
            {
                while (value != array.Min())
                {
                    int index = Array.BinarySearch(array, value);
                    if (index < 0)
                    {
                        value--;
                    }
                    else
                    {
                        while (array[index] == array[index - 1])
                        {
                            index--;
                        }
                        return index;
                    }
                }
            }
            return 0;
        }
    }
}