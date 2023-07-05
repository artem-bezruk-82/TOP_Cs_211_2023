// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #3: Структуры. Классы. Свойства
// Домашнее задание
// Часть #1

// Задание 4
// Создайте класс «Веб-сайт».
// Необходимо хранить в полях класса: название сайта, путь к сайту, описание сайта, ip адрес сайта.
// Реализуйте методы класса для ввода данных, вывода данных, реализуйте доступ к отдельным полям через методы класса. 

namespace hw_03_p1_task4_webSite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebSite google = new WebSite()
            {
                Name = "Google",
                Uri = new Uri("https://google.com/"),
                Description = "Google search service"
            };

            WebSite metanit = new WebSite()
            {
                Name = "Metenit",
                Uri = new Uri("https://metanit.com/"),
                Description = "Site about programming"
            };

            Console.WriteLine(google);
            Console.WriteLine(metanit);
        }
    }
}