using System;
using CollectionPractice.Model;
using CollectionPractice.Details;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main()
        {
            Detailss ObjDetails = new Detailss();
            ObjDetails.Eid=323;
            ObjDetails.Ename="Sakshi Gupta";
            
            EmployeeList ObjEmployee = new EmployeeList();
            ObjEmployee.EmployeeName(ObjDetails);

            List<Detailss> DisplayList = ObjEmployee.DisplayList();
            foreach(var item in DisplayList)
            {
                Console.WriteLine(item.Eid+" "+item.Ename);
            }
           Detailss DObject = ObjEmployee.EmployeeSearch(102);
           Console.WriteLine(DObject.Eid);
        }
    }
}
