using System;

namespace Delegate
{
    class Program
    {
        public static int Student(int n1, int n2)
        {
            return n1*n2;
        }
         public static void Main()
        {
            Func<int, int> Val = Student;
            Console.WriteLine("Hello World!");
        }
    }
}
