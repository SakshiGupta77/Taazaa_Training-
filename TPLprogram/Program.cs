using System;
using System.Threading;

namespace TPLprogram
{
    class Myapp
    {
        public static void LongTask()
        {
            Thread.Sleep(6000);
            Console.WriteLine("going to karolbhag for major, hopfully it will take time");
        }

        public static void Main() 
        {
            Thread obj = new Thread(new ThreadStart(LongTask));
            obj.Start();
            Console.WriteLine("i am inside the main function");  
        }
    }
}
