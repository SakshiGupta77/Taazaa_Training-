using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 323; // value type int
            object obj = num1; // boxing (value type convets into object type)
            num1 = 1234; //change value of num1 does'nt affect obj value
           int num2 = (int)obj; // unboxing (need to type cast)
            Console.WriteLine("object :"+obj);
            Console.WriteLine("num1 :"+num1);
            Console.WriteLine("num unboxing :"+num2);
        }
    }
}
