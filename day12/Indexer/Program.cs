using System;
using Indexer.Employee;
namespace Indexer
{
    class Program
    {
        static void Main()
        {
            Employees employees = new Employees();
            employees.Empid = 101; // at this point set will be called
            Console.WriteLine(employees.Empid); // at this point get will be called
        }
    }
}
