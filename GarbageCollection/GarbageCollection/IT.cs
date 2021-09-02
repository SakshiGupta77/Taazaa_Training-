using System;
namespace GarbageCollection
{
    public class IT : IDisposable
    {
        public void DatabaseCollect() // to connect to database we need so many resources
        {
            Console.WriteLine("let me write a code  to connect with database");
        }

        public void Dispose()
        {
        Console.WriteLine("This is called distructor");     
        }

        // ~ IT() //Finalize()  act as a distructor
        // {
        //     Console.WriteLine("This is called distructor");
        // }
    }
}