// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #3: Структуры. Классы. Свойства
// Домашнее задание

// Задание #1.
// Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара.

namespace material_03_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Article articleA = new Article("article A", 2.5);
            Console.WriteLine(articleA);
            Article articleB = new Article("article B", 0.5);
            Console.WriteLine(articleB);
        }
    }
}