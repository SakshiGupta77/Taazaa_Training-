using System;
namespace OptionalP.Department
{
    public class Employee
    {
        public void EmployeeDetails(string Fname, string Lname,
        int Id = 20, string Department = "Computer Science")
        {
            Console.WriteLine(Fname+" "+Lname+" "+Id+" "+Department);
        }
    }
}