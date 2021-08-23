using System;
namespace New1
{
    struct Comapny // structure declaration
    {
        public int age;
        public string name;
    }
    class Taazaa
    {
        public static void Main(string[] args)
        {
            Comapny c; // declare c1 of Comapny type
            c.name = "harry";
            c.age = 15;        // giving c1 data
            Console.WriteLine("C : "+c.name+ " and "+c.age);
        }
    }
}

