using System;
using day4A.Movie;
using day4A.Study;
namespace day4A
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovie obj1 = new SakshiStudy();
            IStudy obj  = new Sakshi();
            Console.WriteLine(obj1.Movie("movieban"));
        }
    }
}
