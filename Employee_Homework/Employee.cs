using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Homework
{
    public abstract class Employee
    {

        private string _firstName;
        private string _lastName;
        private string _ssn;//social security number

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                this._firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        public string SSN
        {
            get
            {
                return _ssn;
            }
            set
            {
                this._ssn = value;
            }
        }

        protected Employee()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nEmployee Worked");
        }
        public abstract double Earnings();
    }
}
