using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Homework
{
    public class HourlyEmployee : Employee
    {
        private double _hourlyWage;
        private double _hours;
        public double HourlyWage
        {
            get
            {
                return _hourlyWage;
            }
            set
            {
                this._hourlyWage = value;
            }
        }
        public double Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                this._hours = value;
            }
        }
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " " + "SSN: " + SSN + " " + "Hours: " + Hours + " " + "Hourly Wage:" + HourlyWage + "Earnings: " + Earnings();
        }
        public override double Earnings()
        {

            if (_hours <= 40)
            {
                _hourlyWage = _hourlyWage * _hours;
            }
            else if (_hours > 40)
            {
                _hourlyWage = 40 * _hourlyWage + (_hours - 40) * _hourlyWage * 1.5;
            }
            else
            {
                Console.WriteLine("not <0");
            }
            return _hourlyWage;
        }
        public HourlyEmployee()
        {
            Console.WriteLine("***Hourly Employee Worked***");
        }
    }
}
