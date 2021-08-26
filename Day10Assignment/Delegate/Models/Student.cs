using System;
namespace Delegate.Models
{
    public class Student
    {
        public string StudentName(string Name)
        {
            return Name;
        }
         public void StudentRollNo()
        {
            Console.WriteLine("1234");
        }
         public bool StudyStatus(string M)
        {
            return true;
        }
    }
}