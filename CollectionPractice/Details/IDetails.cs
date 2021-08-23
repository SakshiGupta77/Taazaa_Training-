using CollectionPractice.Model;
using CollectionPractice.Details;
using System.Collections.Generic;

namespace CollectionPractice.Details
{
    public interface IDetails
    {
        void EmployeeName(Detailss ObjDetailss);
        List<Detailss> DisplayList();
        void EmployeeSearch(int Emid);
    }
}