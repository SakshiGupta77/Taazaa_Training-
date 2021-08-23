using System;
using System.Collections.Generic;
using CollectionPractice.Details;
namespace CollectionPractice.Model
{
    public class EmployeeList
    {
        List<Detailss> ObjectList = new List<Detailss>();
        public EmployeeList()
        {
            ObjectList = new List<Detailss>(); 
        }
        public void EmployeeName(Detailss ObjDetails)
        {
            ObjectList.Add(ObjDetails);
        }
        public List<Detailss> DisplayList()
        {
            return ObjectList;
        }
        public Detailss EmployeeSearch(int Emid)
        {
            return ObjectList.Find(Employee=>Employee.Eid==Emid); //by using lambda
        }

    }
}