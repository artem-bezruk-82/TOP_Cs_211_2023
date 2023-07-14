using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace pw_03_task5_employee
{
    public static class EmployeeExt
    {
        public static void SetItemConsole(this Employee employee)
        {
            Dictionary<int, string> menu = new Dictionary<int, string>() 
            {
                { 0, "APPLY settings"},
                { 1, "Set First Name"},
                { 2, "Set Middle Name"},
                { 3, "Set Last Name"},
                { 4, "Set Birthday date"},
                { 5, "Set e-mail address"},
                { 6, "Set phone number"},
                { 7, "Set position title"},
                { 8, "Set job description"},
            };

            int menuItem = -1;

            while (menuItem != 0)
            {   
                Console.WriteLine("Employee properties menu");

                foreach (KeyValuePair<int, string> item in menu)
                {
                    Console.WriteLine($"\t{item.Key} - {item.Value}");
                }

                menuItem = (int)GetConsoleInputInt("Please chose laptop parameter", 0, menu.Count);

                switch (menuItem)
                {
                    case 1:
                        SetFirstNameConsole(employee);
                        break;
                    case 2:
                        SetMiddleNameConsole(employee);
                        break;
                    case 3:
                        SetLastNameConsole(employee);
                        break;
                    case 4:
                        SetBirthDateConsole(employee);
                        break;
                    case 5:
                        SetEmailConsole(employee);
                        break;
                    case 6:
                        SetPhoneConsole(employee);
                        break;
                    case 7:
                        SetPositionConsole(employee);
                        break;
                    case 8:
                        SetDescriptionConsole(employee);
                        break;
                    default:
                        break;
                }
            }
        }

        public static void SetFirstNameConsole(this Employee employee)
        {
            Console.WriteLine($"Please enter {nameof(employee.FirstName)}");
            employee.FirstName = Console.ReadLine() ?? string.Empty;
        }

        public static void SetMiddleNameConsole(this Employee employee)
        {
            Console.WriteLine($"Please enter {nameof(employee.MiddleName)}");
            employee.MiddleName = Console.ReadLine() ?? string.Empty;
        }

        public static void SetLastNameConsole(this Employee employee)
        {
            Console.WriteLine($"Please enter {nameof(employee.LastName)}");
            employee.LastName = Console.ReadLine() ?? string.Empty;
        }

        public static void SetBirthDateConsole(this Employee employee) 
        {
            Console.WriteLine("Please enter established date, using DD.MM.YYYY format");
            employee.BirthDate = DateOnly.Parse(Console.ReadLine() ?? string.Empty);
        }

        public static void SetEmailConsole(this Employee employee) 
        {
            Console.WriteLine("Please enter e-mail address");
            employee.Email = new System.Net.Mail.MailAddress(Console.ReadLine() ?? string.Empty);
        }

        public static void SetPhoneConsole(this Employee employee) 
        {
            employee.Phone = $"{GetConsoleInputInt("Please enter 11-digits phone", 10000000000, 99999999999)}";
        }

        public static void SetPositionConsole(this Employee employee) 
        {
            Console.WriteLine("Please enter position title");
            employee.Position = Console.ReadLine() ?? string.Empty;
        }

        public static void SetDescriptionConsole(this Employee employee)
        {
            Console.WriteLine("Please enter job description");
            employee.Description = Console.ReadLine() ?? string.Empty;
        }

        private static Int64 GetConsoleInputInt(string requestText, 
            Int64 startRange= Int64.MinValue, Int64 endRange = Int64.MaxValue)
        {
            Int64? value = null;

            do 
            {
                while (value is null)
                {
                    Console.WriteLine(requestText);
                    try
                    {
                        value = Int64.Parse(Console.ReadLine() ?? "");
                    }
                    catch (Exception exc)
                    {

                        Console.WriteLine($"{exc.Message} Please enter integer value");
                    }
                }
                if (value < startRange || value > endRange)
                    throw new ArgumentOutOfRangeException(nameof(value), value , 
                        message: $"value is out of {startRange}...{endRange} value");
            } while (value < startRange || value > endRange);

            return (Int64)value;
        }
    }
}
