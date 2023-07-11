// Курс: Платформа Microsoft .NET и язык программирования C#
// Урок #5: Тема: Перегрузка операторов. Индексаторы и свойства
// Домашнее задание

// Задание 1
// Ранее в одном из практических заданий вы создавали класс «Журнал».
// Добавьте к уже созданному классу информацию о количестве сотрудников.
// Выполните перегрузку
// + (для увеличения количества сотрудников на указанную величину),
// — (для уменьшения количества сотрудников на указанную величину),
// == (проверка на равенство количества сотрудников),
// < и > (проверка на меньше или больше количества сотрудников),
// != и Equals.
// Используйте механизм свойств для полей класса.

namespace hw_05_task1_magazine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine science = new Magazine()
            {
                Name = "Science and technology",
                EstDate = new DateOnly(1975, 1, 1),
                Description = "Magazine about science and technologies",
                Email = new System.Net.Mail.MailAddress("st@mail.com"),
                Phone = "76543210000",
                NumOfEmployees = 5
            };

            Magazine low = new Magazine()
            {
                Name = "Person and law",
                EstDate = new DateOnly(1972, 3, 21),
                Description = "Magazine about litigation and crimes investigations",
                Email = new System.Net.Mail.MailAddress("pl@mail.com"),
                Phone = "78901234567",
                NumOfEmployees = 9
            };

            Console.WriteLine(science);
            Console.WriteLine(low);

            MagazineExt.PrintComparisonConsole(science, low);
            MagazineExt.PrintComparisonConsole(low, science);

            science += 2;
            low -= 2;

            MagazineExt.PrintComparisonConsole(science, low);
        }
    }
}