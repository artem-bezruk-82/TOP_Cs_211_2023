// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #3: Структуры. Классы. Свойства
// Домашнее задание

// Задание #3
// Описать структуру RequestItem содержащую поля: товар; количество единиц товара.

namespace material_03_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestItem requestItem = new RequestItem(new Article("article 1", 76.25), 5);
            Console.WriteLine(requestItem);
        }
    }
}