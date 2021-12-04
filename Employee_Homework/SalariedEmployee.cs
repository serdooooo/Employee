using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Homework
{
    public class SalariedEmployee : Employee
    {
        private double _weeklySalary;
        public double WeeklySalary
        {
            get
            {
                return _weeklySalary;
            }
            set
            {
                this._weeklySalary = value;
            }
        }
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " " + "SSN: " + SSN + " " + "Earnings: " + Earnings();
        }

        public override double Earnings()//total kazanç
        {
            return _weeklySalary;
        }

        public SalariedEmployee()
        {

            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("***Salaried Employee Worked***");
        }
    }
}
