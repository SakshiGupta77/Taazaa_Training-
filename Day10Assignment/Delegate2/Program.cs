using System;
using Delegate2.models;
delegate void StudentsDelegate(string F, string L);
namespace Delegate2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsDelegate Obj = new StudentsDelegate(StudentsList.StudentsName); //using delegate
            Obj.Invoke("Sakshi","Gupta");

            //LAMBDA FUNCTION
           StudentsDelegate student =(string F, string L)=> 
           {
               Console.WriteLine(F+ " "+L);
           };
           //ANONYMOUS METHOD
            StudentsDelegate Std = delegate (string F, string L) // Anonymous function
           {
               Console.WriteLine(F+","+L);
           };
           student("ABhinav","Sharma");
           Std("AArush","Gupta");
        }
    }
}
