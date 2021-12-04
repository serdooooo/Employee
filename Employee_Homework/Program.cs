using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            SalariedEmployee S1 = new SalariedEmployee();
            S1.FirstName = "Serdar";
            S1.LastName = "Karakurt";
            S1.SSN = "123456";
            S1.WeeklySalary = 1700.50;
            Console.WriteLine(S1.ToString());

            CommissionEmployee C1 = new CommissionEmployee();
            C1.FirstName = "Faik";
            C1.LastName = "Turan";
            C1.SSN = "654321";
            C1.CommissionRate = 10;
            C1.GrossSales = 200;
            Console.WriteLine(C1.ToString());

            HourlyEmployee H1 = new HourlyEmployee();
            H1.FirstName = "Erdem";
            H1.LastName = "Başkan";
            H1.SSN = "134874";
            H1.Hours = 41;
            H1.HourlyWage = 20;
            Console.WriteLine(H1.ToString());

            BasePlusCommissionEmployee B1 = new BasePlusCommissionEmployee();
            B1.FirstName = "Fatih";
            B1.LastName = "Reis";
            B1.SSN = "0548412";
            B1.CommissionRate = 10;
            B1.GrossSales = 200;
            B1.BaseSalary = 3000;
            Console.WriteLine(B1.ToString());

            Console.ReadKey();
        }
    }
}
