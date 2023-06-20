// КУРС: «ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#
// Тема: Массивы и строки
// Модуль 2
// Практическое задание

// Задание 1
// Создайте приложение, которое отображает количество чётных, нечётных, уникальных элементов массива.


namespace pw_02_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = { 4, 2, 0, 3, 1, 2, 0, 5, 1 };
            Console.WriteLine(string.Join(' ', myArr));
            Array.Sort(myArr);

            int oddValuesCounter = 0;
            int evenValuesCounter = 0;
            int zeroesCounter = 0;
            int? currentValue = null;

            foreach (int item in myArr) 
            {
                if (item != currentValue) 
                {
                    if (item == 0) 
                    {
                        zeroesCounter++;
                    } 
                    else if (item % 2 == 0) 
                        evenValuesCounter++;
                    else if (item % 2 != 0) 
                        oddValuesCounter++;


                    currentValue = item;
                }
            }

            Console.WriteLine($"Uniq elemets: {evenValuesCounter + oddValuesCounter + zeroesCounter}" +
                $"\nThat are: \n\tUniq even values: {evenValuesCounter}; \n\tUniq odd values: {oddValuesCounter}; " +
                $"\n\tZero: {zeroesCounter}; ");

        }


    }
}