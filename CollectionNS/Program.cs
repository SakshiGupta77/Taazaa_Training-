using System;
using CollectionNS.School;
namespace CollectionNS
{
    class Program
    {
        static void Main()
        {
           var Object = new Studentlist();
           var name = Object.StudentRollNo();
           var details = Object.StudentPhone();
           int count = name.Count;
           for(int i=0;i<count;i++)
           {
               Console.WriteLine(name[i]);
           }
           int countAll = details.Count;
           for(int i=0;i<countAll;i++)
           {
               Console.WriteLine(details[i].phone+" "+details[i].roll);
           }
        }
    }
}
