using System;
using day6.Collections;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
           var Object = new Candidates();
           var str = Object.addCandidatesName();
           Console.WriteLine(str);
           Object.addCandidatesNames();
        }
    }
}
