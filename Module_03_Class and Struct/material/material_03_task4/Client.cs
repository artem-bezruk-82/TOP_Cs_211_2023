using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace material_03_task4
{
    public struct Client
    {
        public int Code { get; private set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address ClientAddress { get; set; }

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

        public int NumberOfRequests { get; set; }
        public double ExpensesTotal { get; set; }
        public static int Count { get; private set; }

        static Client() { Count = 0; }

        public Client(string firstName, string middleName, string lastName, 
            Address clientAddress, int numberOfRequests, double expensesTotal)
        {
            Code = ++Count;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            ClientAddress = clientAddress;
            NumberOfRequests = numberOfRequests;
            ExpensesTotal = expensesTotal;
        }

        public Client(string firstName, string middleName, string lastName, Address clientAddress)
            : this(firstName, middleName, lastName, clientAddress, 0, 0.00) { }

        public void AddExpanse(double expense)
        {
            ExpensesTotal += expense;
            NumberOfRequests++;
        }

        public override string ToString()
        {
            return $"\t|Code: {Code}\t|{FirstName} {MiddleName} {LastName}\t|{ClientAddress}\t|{Phone}" +
                   $"\t|Number of requests: {NumberOfRequests} \t|ExpensesTotal: {ExpensesTotal}";
        }
    }
}
