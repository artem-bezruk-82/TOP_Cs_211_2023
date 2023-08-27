// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок 2: Массивы, строки, перечисления
// Методический материал

// Упражнение 4
// В двумерном массиве порядка M на N поменяйте местами заданные столбцы.


namespace ex_02_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray2D = 
            {
                { 1,2,3,4,5},
                { 1,2,3,4,5},
                { 1,2,3,4,5},
                { 1,2,3,4,5}
            };

            PrintArray2DConsole(myArray2D);
            try 
            {
                SwapColumnnsArray2D(myArray2D, 1, 3);
            } 
            catch (IndexOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
            PrintArray2DConsole(myArray2D);
        }

        static void SwapColumnnsArray2D(int[,] array2D, int columnA, int columnB)  
        {
            if (columnA >= 0 && columnA <= array2D.GetUpperBound(1))
            {
                if (columnB >= 0 && columnB <= array2D.GetUpperBound(1))
                {
                    for (int i = 0; i <= array2D.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j < array2D.GetUpperBound(1); j++)
                        {
                            if (j == columnA)
                            {
                                (array2D[i,j], array2D[i,columnB]) = (array2D[i,columnB], array2D[i,j]);
                            }
                        }
                    }
                }
                else 
                {
                    throw new IndexOutOfRangeException($"{nameof(columnB)} is out of 0...{array2D.GetUpperBound(1)} range");
                }
            }
            else 
            {
                throw new IndexOutOfRangeException($"{nameof(columnA)} is out of 0...{array2D.GetUpperBound(1)} range");
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