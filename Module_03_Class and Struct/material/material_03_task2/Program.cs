// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #3: Структуры. Классы. Свойства
// Домашнее задание

// Задание #2
// Описать структуру Client содержащую поля:
// код клиента; ФИО; адрес; телефон;
// количество заказов осуществленных клиентом;
// общая сумма заказов клиента.

namespace material_03_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client()
            {
                FirstName = "Vasily",
                MiddleName = "Petrovich",
                LastName = "Ivanov",
                ClientAddress = new Address()
                {
                    PostalIndex = 394000,
                    City = "Voronezh",
                    Street = "Karla Marksa",
                    Building = 94,
                },
            };

            Console.WriteLine(client);
        }
    }
}