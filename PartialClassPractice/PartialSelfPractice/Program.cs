using System;
using PartialSelfPractice.Department;
namespace PartialSelfPractice
{
    class Program
    {
        static void Main()
        {
            Employee emp = new Employee(200);
            int Emp = emp.EmpId();
            Console.WriteLine(Emp);
        }
    }
}
