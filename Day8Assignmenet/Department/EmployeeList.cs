using System;
using System.Collections.Generic;
using Day8Assignmenet.Model;
namespace Day8Assignmenet.Department
{
    public class EmployeeList
    {
        List<Details> ObjectList = new List<Details>();
        public EmployeeList()
        {
            ObjectList = new List<Details>();
        }
        public void EmployeeName(Details ObjectDetails)
        {
            ObjectList.Add(ObjectDetails);
        }
        public void EmployeeId(Details ObjectId)
        {
            ObjectList.Add(ObjectId);
        }
        public void EmployeePhone(Details ObjectPhone)
        {
            ObjectList.Add(ObjectPhone);
        }
        public List<Details> DisplayDetails()
        {
            return ObjectList;
        }
        public Details EmployeeSearch(string name)
        {
            return ObjectList.Find(Employee=>Employee.Ename==name);
        }
    }
}