using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LINQ.Models;
namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();  
            var query = from ele in school.Students select ele;  
            List<Student> lstStudents = query.ToList(); 
        }
    }
}
