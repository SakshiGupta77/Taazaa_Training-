using System;
using Day8T.AdvDelegate;
//delegate string NameDelegate(string N);
delegate void PhoneDelegate();
delegate bool StudyDelegate();

namespace Day8T
{
    class Program
    {
        static void Main()
        {
            Study sObj = new Study();
            //NameDelegate nameDelegate = new NameDelegate(sObj.Name);
            //var n = nameDelegate("Sakshi");
            //Console.WriteLine(n);
            Func<string,string> func = sObj.Name;
            string fob = func("sakshi");
            Console.WriteLine(fob);

        }
    }
}
