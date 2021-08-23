using System;
using System.Collections.Generic;
using Day8Assignmenet.Department;
using Day8Assignmenet.Model;

namespace Day8Assignmenet
{
    class Program
    {
        static void Main()
        {
            Details DObject =  new Details();
            DObject.Ename="Sakshi";
            DObject.EId=323;

            Details DObject1 =  new Details();
            DObject1.Ename="Shivani";
            DObject1.EId=4422;

            EmployeeList EObject = new EmployeeList();
            EObject.EmployeeName(DObject);
            EObject.EmployeeName(DObject1);

            List<Details> DisplayDetails = EObject.DisplayDetails();
            foreach (var item in DisplayDetails)
            {
                Console.WriteLine(item.EId+" "+item.Ename);
            }
            Details Object = EObject.EmployeeSearch("Sakshi");
            Console.WriteLine(Object.Ename);
        }
    }
}
