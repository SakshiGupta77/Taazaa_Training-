using System;
using System.Threading;
namespace ThreadingProgram
{
   public  class Mywork
   {
       public void Work1()
       {
           Thread.Sleep(7000); // this function will take 7seconds to perform the task
           Console.WriteLine("I am doing for work1");
       }
       public void Work2()
       {
           Console.WriteLine("I am doing for work2");
       }
        static void Main() // main is a thread, thread means it provides the execution to the program, or we can say thread is a execution odel of the program
        {
            Mywork mywork = new Mywork();
            mywork.Work1(); // at this point we invoking the first function is called work1.
            mywork.Work2(); // at this point we invoking the second function is called work2.
        }
   }
}
