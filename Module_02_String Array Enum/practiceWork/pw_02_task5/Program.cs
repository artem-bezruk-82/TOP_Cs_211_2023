// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 5
// Разработайте приложение, которое будет находить минимальное и максимальное значение в двумерном массиве. 


namespace pw_02_task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array2D = new int[random.Next(3,9), random.Next(3, 9)];
            FillInArray2DRandom(array2D);
            PrintArray2DConsole(array2D);

            int max = array2D[0, 0];
            int min = array2D[0, 0];

            foreach (int item in array2D)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }

            Console.WriteLine($"Max value: {max}; Min Value: {min}");
        }

        static void FillInArray2DRandom(int[,] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }
        }

        static void PrintArray2DConsole(int[,] array)
        {
            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}