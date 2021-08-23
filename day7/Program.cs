using System;
using day7.Delegate;
delegate int customDelegate();
namespace day7
{
    class Program
    {
        static void Main(string[] args)
        {
            var Object = new Person();
            customDelegate cObj = new customDelegate(Object.phonNo);
            var temp = cObj.Invoke();
            Console.WriteLine(temp);
            cObj-=Object.walk;  //multicast (one more ftn add)
            var temp1 = cObj.Invoke();
            Console.WriteLine(temp1);
        }
    }
}
