using System;
using Mislleneous.IT;

namespace Mislleneous
{
    class Program
    {
        static void Main(string[] args)
        {
            var Mohan = new Taazaa(101,1000);
            var Sachin = new Taazaa(102,2000);
            var str = Mohan.EmployeeSalary();
            Console.WriteLine(str);


            var strr = Sachin.EmployeeSalary();
            Console.WriteLine(strr);

            var cff = Taazaa.CoffeeHouse();
            Console.WriteLine(cff);

            Console.WriteLine(Taazaa.CoffeeHouse());
        }
    }
}
