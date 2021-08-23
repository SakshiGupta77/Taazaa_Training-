using System;
using saturday.Collections;
namespace Saturday
{
    class Program
    {
        static void Main(string[] args)
        {
            var Obj = new StudentsList();
            var name = Obj.StudentDetails();
            var count = name.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}
