// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок 2: Массивы, строки, перечисления
// Методический материал

// Упражнение 2
// Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные
// (0 считать положительным)

namespace ex_02_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] myArray = { 1, -2, -3, 4, 5, -6, -7, 8, 9, 0 };
            Console.WriteLine($"{nameof(myArray)} = [{string.Join(", ", myArray)}]");
            Array.Sort(myArray);
            Console.WriteLine($"{nameof(myArray)} = [{string.Join(", ", myArray)}]");
        }
    }
}