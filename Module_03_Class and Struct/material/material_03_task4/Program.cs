// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #3: Структуры. Классы. Свойства
// Домашнее задание

// Задание #4
// Описать структуру Request содержащую поля:
// код заказа; клиент; дата заказа; перечень заказанных товаров;
// сумма заказа (реализовать вычисляемым свойством).

namespace material_03_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Request request = new Request(
                new Client("Vasily", "Petrovich", "Ivanov", 
                new Address()
                {
                    PostalIndex = 394000,
                    City = "Voronezh",
                    Street = "Karla Marksa",
                    Building = 94,
                })
            );

            request.AddRequestItem(new RequestItem(new Article("test 1", 33.5), 5));
            Console.WriteLine(request);
            request.AddRequestItem(new RequestItem(new Article("test 2", 23.8), 3));
            Console.WriteLine(request);
        }
    }
}