using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPLprogram
{
    class Myapp
    {   
        public static void LongTask()
        {
            Thread.Sleep(12000); // 10 sec
            Console.WriteLine("LongTask takes 7 second");
        }
        public static async void myTask()
        {
            //Task task = new Task(new Action(LongTask));
            await Task.Run(new Action(LongTask)); //new thread 
            Console.WriteLine("new thread is generated");
            //task.Start();
        }

        public static void Main() 
        {
             myTask();
             Console.WriteLine("this is main thread");
             Console.ReadLine();
        }
    }
}
