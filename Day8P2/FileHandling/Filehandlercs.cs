using System;
using System.IO;
namespace Day8P2.FileHandling
{
    public class Filehandlercs
    {
        public void writeToFile(string name)
        {
            FileStream f = new FileStream("Training.txt", FileMode.Create); // open notebook
            StreamWriter s = new StreamWriter(f); // open pen
            s.WriteLine(name); //write content
            s.Close(); //close pen 
            f.Close(); //close notebook
        }
        public void readFromFile() //to read the file
        {
            FileStream f = new FileStream("Training.txt", FileMode.Open);
            StreamReader reader = new StreamReader(f);
            string fileData = reader.ReadLine();
            Console.WriteLine(fileData);
            reader.Close();
            f.Close();
            
        }
    }
}