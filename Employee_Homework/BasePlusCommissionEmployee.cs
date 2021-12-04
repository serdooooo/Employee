using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Homework
{
    public class BasePlusCommissionEmployee:CommissionEmployee
    {
        private double _baseSalary;
        public double BaseSalary //asgari ücret
        {
            get
            {
                return _baseSalary;
            }
            set
            {
                this._baseSalary = value;
            }
        }

        public override double Earnings()//total kazanç
        {
            return (CommissionRate * GrossSales) + BaseSalary;
        }
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " " + "SSN: " + SSN + " " + "Commission Rate: " + CommissionRate + " " + "Gross Sales: " + GrossSales + " " + "Earnings:" + Earnings();
        }
        public BasePlusCommissionEmployee()
        {
            Console.WriteLine("***BasePlusCommissionEmployee Worked***");
        }
    }
}
