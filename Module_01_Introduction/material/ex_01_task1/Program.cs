// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок 2: Массивы, строки, перечисления
// Методический материал

// Упражнение 1
// Сжать массив, удалив из него все 0 и, заполнить освободившиеся справа элементы значениями –1

namespace ex_01_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 0, 2, 0, 3, 0, 4, 0, 5, 0, 6 };
            Console.WriteLine($"{nameof(myArray)} = [{string.Join(", ", myArray)}]");
            ShrinkArray(ref myArray);
            Console.WriteLine($"{nameof(myArray)} = [{string.Join(", ", myArray)}]");
        }

        static void ShrinkArray(ref int[] array) 
        {
            int[] temp = new int[array.Length];
            int tempIndex = 0;
            foreach (int i in array) 
            {
                if (i != 0) 
                {
                    temp[tempIndex] = i;
                    tempIndex++;
                }
            }
            for (int i = tempIndex; i < temp.Length; i++)
            {
                temp[i] = -1;
            }
            array = temp;
        }
    }
}