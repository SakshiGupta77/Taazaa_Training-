using System;
using Day8T.AdvDelegate;

//delegate void PhoneDelegate();
delegate bool StudyDelegate();

namespace Day8T
{
    class Program
    {
        static void Main()
        {
            Study sObj = new Study();
            Func<string,string> func = sObj.Name;
            string fob = func("sakshi");
            Console.WriteLine(fob);

            Action Obj = sObj.PhoneNo; 
            Obj();
            Predicate<string> Pobj = sObj.StudyStatus;
            bool pd = Pobj("gupta");
            Console.WriteLine(pd);

        }
    }
}
