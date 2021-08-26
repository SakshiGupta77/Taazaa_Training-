using System;
using Delegate.Models;
namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Func<string,string> func = student.StudentName;
            string function = func("Sakshi Gupta");
            Console.WriteLine(function);

            Action action = student.StudentRollNo; 
            action();
            Predicate<string> predicate = student.StudyStatus;
            bool prdt = predicate("Abhinav gupta");
            Console.WriteLine(prdt);
        }
    }
}
