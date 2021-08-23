using System;
using SelfAnalyse.Self;

namespace SelfAnalyse
{
    class Program
    {
        static void Main()
        {
            var Sakshi = new Taazaa(1,1000);
            var Gupta = new Taazaa(3,4000);
            Console.WriteLine(Sakshi.EmployeeSalary());
            Console.WriteLine(Gupta.EmployeeSalary());
            Console.WriteLine(Taazaa.CoffeeSpace());
        }
    }
}
