using System;
namespace SelfAnalyse.Self
{
    public class Taazaa
    {
        double Salary;
        readonly int EmployeeId;
        static string Cafeteria;

        public Taazaa(int empid, double sal) //static constructor
        {
            Salary = sal;
            EmployeeId = empid;
        }
        static Taazaa() //static function
        {
            Cafeteria = "200";
        }
        public int Employeeid()
        {
            return EmployeeId;
        }

        public static string CoffeeSpace()
        {
            return Cafeteria ;
        }
        public double EmployeeSalary()
        {
            return Salary;
        }
    }

}