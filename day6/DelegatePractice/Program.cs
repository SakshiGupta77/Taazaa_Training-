using System;
using DelegatePractice.Noida;
delegate int DelegateBroker();
namespace DelegatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var Object = new Broker();
            DelegateBroker flat = new DelegateBroker(Object.Flat1);
            //var temp = flat.Invoke();
            Console.WriteLine(flat.Invoke());
            flat += Object.Flat3;
            Console.WriteLine(flat.Invoke());
        }
    }
}
