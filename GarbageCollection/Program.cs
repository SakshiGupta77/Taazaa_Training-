// difference between finalize and dispose
using System;
using GarbageCollection;
namespace GarbageCollection
{
    class Program
    {
        static void Main()
        {
            // we are defining the scope of an object using block. Achieves Explicit Garbage collection
           using( IT iT = new IT())
           {
               iT.DatabaseCollect(); // now the function is called, got the value still resources are running so, why nott clean up the resources just after consuming.
                                 // this is where garbage collection comes in the picture.
           } 
           // at this point dispose function will be called explicitely

            Console.WriteLine("End of the Program");
        }
    }
}
