//              INDEXER
using System;

namespace MajorLogicApplications
{
    public class Employee
    {
        private object[] data = new object[2]; //variable name is data and done indexing with 2 subscript. data[0]=101,data[1]="Sakshi";

        public object this[int i] // this refered to employee
        {
            get
            {
                return data[i];
            }
            set
            {
                data[i] = value;
            }
        }
    } 
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee[0]=121; // set  //data[0] = employee[zero]; data[1]=employee[1];
            employee[1]="Sakshi"; //set

            Console.WriteLine(employee[0]);  //get
            Console.WriteLine(employee[1]);  //set
        }
    }
}
