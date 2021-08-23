using System.Collections;
using System.Collections.Generic;
using CollectionNS.Models2;
namespace CollectionNS.School
{
    public class Studentlist
    {
        public ArrayList StudentRollNo()
        {
            ArrayList studentName = new ArrayList();
            studentName.Add("Sakshi");
            studentName.Add("Garima");
            return studentName;
        }
        public List<Student> StudentPhone()
        {
            List<Student> obj  = new List<Student>();
            obj.Add(new Student{
                phone = 987654321,
                roll = 32
            });
            return obj;
        }
    }
}