using System;

namespace Loop1    
{
    class Program
    {
        static void Main()
        {
            // Read 5 numbers from keyboard and find their sum and average.
            
            int i,num,sum=0;
            Console.WriteLine("Input 5 numbers : ");
            for(i=1;i<=5;i++)
            {
                Console.WriteLine("Number-{0} :"+i);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            double average = sum/5;
            Console.WriteLine("The sum of the number : "+ sum+"The average of the number : "+average);
        }
    }
}
