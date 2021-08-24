using System;

namespace ValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 32;
            Change(ref num1);
            Console.WriteLine(num1);
        }
        public static void Change(ref int num2)
        {
            num2 = 1234;
        }
    }
}
