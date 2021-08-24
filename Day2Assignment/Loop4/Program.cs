using System;

namespace Loop4
{
    class Program
    {
        static void Main(string[] args)
        {
            //to display the n terms of odd natural number and their sum.
            int n,sum=0;

            Console.Write("Input number of terms : ");
            n= Convert.ToInt32(Console.ReadLine());   
            for(int i=1;i<=n;i++)
            {
                Console.Write("odd number : "+ (2*i-1));
                sum+=2*i-1;
            }
            Console.Write("\nThe Sum of odd Natural Number are : "+sum);
        }
    }
}
