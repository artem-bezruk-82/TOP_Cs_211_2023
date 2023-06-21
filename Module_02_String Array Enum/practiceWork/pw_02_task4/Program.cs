// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 4
// Даны 2 массива размерности M и N соответственно.
// Необходимо переписать в третий массив общие элементы первых двух массивов без повторений. 

namespace pw_02_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr1 = { 0, 1, 2, 3, 4, 2 };
            int[] myArr2 = { 2, 3, 4, 5, 4 };
            int[] commonElements = GetArrayIntersection(myArr1, myArr2);
            Console.WriteLine(string.Join(' ', myArr1));
            Console.WriteLine(string.Join(' ', myArr2));
            Console.WriteLine(string.Join(' ', commonElements));
        }

        static int[] GetArrayIntersection(int[] arrayA, int[] arrayB) 
        {
            int[] intersection = new int[0];
            for (int i = 0; i < arrayA.Length; i++)
            {
                if (Array.Exists(arrayB, element => element == arrayA[i]))
                {
                    if (!Array.Exists(intersection, element => element == arrayA[i]))
                    {
                        ArrayPushBack(ref intersection, arrayA[i]);
                    }
                }
            }
            return new int[] { 1, 2, 3 };
        }

        static void ArrayPushBack(ref int[] array, int value)
        {
            int[] tempArray = new int[array.Length + 1];
            Array.Copy(array, 0, tempArray, 0, array.Length);
            tempArray[tempArray.GetUpperBound(0)] = value;
            array = tempArray;
        }
    }
}