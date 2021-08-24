using System;
using ListPractice.StudentList;
using ListPractice.Models;
using System.Collections.Generic;

namespace ListPractice
{
    class Program
    {
        static void Main()
        {
           Details DObject1 = new Details();
           DObject1.Sname="Sakshi Gupta";
           DObject1.Sroll = 323;

           Details DObject2 = new Details();
           DObject2.Sname="Sakshi Gupta";
           DObject2.Sroll = 323;

           StudentListscs SObject = new StudentListscs();
           SObject.StudentName(DObject1);
           SObject.StudentName(DObject2);

           List<Details> details = SObject.Display();
           foreach(var item in details)
           {
               Console.WriteLine(item.Sname+" "+item.Sroll);
           }
        }
    }
}
