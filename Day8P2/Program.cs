using System;
using Day8P2.FileHandling;

namespace Day8P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Filehandlercs filehandler = new Filehandlercs();
            //filehandler.writeToFile("I am Sakshi gupta");
            filehandler.readFromFile();
        }
    }
}
