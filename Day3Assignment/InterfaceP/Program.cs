using System;
namespace InterfaceP
{
    interface Company
    {
        public void Change()
        {
            Console.WriteLine("Hello World");
        }
    }
    class Program : Company
    {
        public void display()
        {
            Console.WriteLine("Csharp");
        }
        public static void Main()
        {
            Program P = new Program();
            P.display();
        }
    }
}
