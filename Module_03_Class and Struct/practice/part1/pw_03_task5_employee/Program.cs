// КУРС: "ПЛАТФОРМА MICROSOFT .NET И ЯЗЫК ПРОГРАММИРОВАНИЯ C#"
// Тема: Top level statements. Введение в классы. Обработка исключений
// Модуль 3. Часть 1 
// Практическое задание

// Задание 5
// Реализуйте класс «Сотрудник».
// Необходимо хранить в полях класса: ФИО, дату рождения, контактный телефон, рабочий email, должность,
// описание служебных обязанностей.
// Реализуйте методы класса для ввода данных, вывода данных,
// реализуйте доступ к отдельным полям через методы класса

namespace pw_03_task5_employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.SetItemConsole();
            Console.WriteLine(employee);
        }
    }
}