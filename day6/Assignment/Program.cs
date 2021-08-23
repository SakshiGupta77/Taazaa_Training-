using System;
using Assignment.Model;
using Assignment.Taazaa;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            var Obj1 = new Contacts();
            var list = Obj1.StudentDetails();
            int count = list.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(list[i].name+" "+list[i].id+" "+list[i].phoneNo);
            }
            list.Remove(new Details{id = 101});
            foreach(Details i in list)
            {
                Console.WriteLine(list);
            }
        }
    }
}
