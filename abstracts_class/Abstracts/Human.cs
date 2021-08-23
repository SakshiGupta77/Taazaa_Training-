using System;
namespace abstracts_class.Abstracts
{
    public abstract class Human //abstract calss
    {
        public void Asset()
        {
            Console.WriteLine("father is everything");
        }
        public abstract void job(); // abstract metho
    }
    public class Person: Human
    {
            public override void job()
            {
                Console.WriteLine("yes i got a job");
            }
            var obj = new Person();
            obj.Asset();
            obj.job();
    }
}