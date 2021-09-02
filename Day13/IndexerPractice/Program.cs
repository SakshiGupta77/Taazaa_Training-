using System;

namespace IndexerPractice
{
    class Students
    {
        private object[] details = new object[3];
        public object this[int i]
        {
            get
            {
                return details[i];
            }
            set
            {
                details[i] = value;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Students students = new Students();
            students[0] = 121;
            students[1] = "Sakshi";
            students[2] = 121324354;

            Console.WriteLine("name : "+students[1]+" rollno. : "+students[0]+" phoneNo. : "+s)
        }
    }
}
