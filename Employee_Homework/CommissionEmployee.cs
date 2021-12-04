using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Homework
{
    public class CommissionEmployee : Employee
    {
        private double _grossSales;
        private double _commissionRate;
        public double GrossSales//brüt satış
        {
            get
            {
                return _grossSales;
            }
            set
            {
                this._grossSales = value;
            }
        }
        public double CommissionRate//komisyon oranı
        {
            get
            {
                return _commissionRate;
            }
            set
            {
                this._commissionRate = value;
            }
        }
        public override double Earnings()
        {
            return _commissionRate * _grossSales;
        }
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " " + "SSN: " + SSN + " " + "Commission Rate: " + CommissionRate+" "+"Gross Sales: "+GrossSales+" "+"Earnings:"+Earnings();
        }

        public CommissionEmployee()
        {
            Console.WriteLine("***Commission Employee Worked***");
        }
    }
}
