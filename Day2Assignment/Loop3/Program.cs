using System;

namespace Loop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //To display the n terms of square natural number and their sum
            int n,sum=0;
            Console.Write("Input the number of terms : ");
            n= Convert.ToInt32(Console.ReadLine());     
            for(int i=1;i<=n;i++)
            {
                Console.Write("{0}  ",i*i);
                sum+=i*i;
            }
            Console.Write("The Sum of Square  "+n+" is "+sum);
        }
    }
}
