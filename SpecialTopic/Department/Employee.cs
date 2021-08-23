using System;
namespace SpecialTopic.Department
{
    public class Employee
    {
        public void ListOfEmployee(params object [] Id)
        {
            // foreach(int item in Id)
            // {
            //     Console.WriteLine(item);
            // }
            for(int i=0;i<Id.Length;i++)
            {
                Console.WriteLine(Id[i]);
            }
        }
    }
}