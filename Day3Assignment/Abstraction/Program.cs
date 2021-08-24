using System;

namespace Abstraction
{
    abstract class Company //abstract class
    {
        public abstract void Change(); //abstract method
    }
    class Program : Company    //Program inherit company
    {
        public override void Change()
        {
            Console.WriteLine("abstract method");
        }
    }
class Taazaa
{
        static void Main(string[] args)
        {
            Program p = new Program(); // reference of company class
            Console.WriteLine();
        }
}
}
