using System;
using PartialClassImpl.PartialClassImp;
namespace PartialClassImpl
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(101);
            int a = person.getId();
            Console.WriteLine(a);
        }
    }
}
