using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace pw_03_task5_employee
{
    public class Employee
    {
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }

        public DateOnly? BirthDate { get; set; }
        public string? Position { get; set; }
        public string? Description { get; set; }
        public MailAddress? Email { get; set; }

        private string? _phone;
        public string? Phone
        {
            get { return _phone; }
            set
            {
                if (value?.Length != 11)
                {
                    throw new ArgumentOutOfRangeException(value, message: "Telephon number must contain 11 digits");
                }

                Int64 number;

                if (Int64.TryParse(value, out number))
                {
                    _phone = $"+{value}";
                }
                else
                {
                    throw new ArgumentException("It is not a number");
                }
            }
        }

        public Employee(string? firtsName, string? middleName, string? lastName, DateOnly? birthDate)
        {
            FirstName = firtsName;
            MiddleName = middleName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        public Employee() : this(null, null, null, null) { }

        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName}, {BirthDate?.ToShortDateString()}, {Position}, " +
                $"e-mail: {Email}, phone {Phone}";
        }

    }
}
