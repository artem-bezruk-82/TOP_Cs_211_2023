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
            Article article = new Article();
            Article article1 = new Article("article 1", 12);
            Article article2 = new Article("article 2", null);
            Article article3 = new Article("article 3");
            Article? article4 = null;

            Console.WriteLine(article);
            Console.WriteLine(article1);
            Console.WriteLine(article2);
            Console.WriteLine(article3);
            Console.WriteLine(article4);
        }
    }
}