using System;

namespace Polymorphism
{
    class Person
    {
        //example of method overloading
        public int Walk(int a)
        {
            return a;
        }
        // public string Walk(string a)
        // {
        //     return a;
        // }
    }
    class Program
    {
        static void Main()
        {
         Person person = new Person();
         int a = person.Walk(2); //association of an object with method is said to be early binding
         //association of an object with the Overloaded method is said to be static polymorphism
         //string b=person.Walk("infinity  park");  
         Console.WriteLine(a+" km"); 
        }
    }
}
