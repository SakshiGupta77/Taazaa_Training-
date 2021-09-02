using System;
using System.Collections.Generic;
namespace ListPracticeone
{
    public class CandidateList
    {
        List<CandidateDetails> candidateDetails = new List<CandidateDetails>();
        public int CandidateName(CandidateDetails name)
        {
            candidateDetails.Add(name);
            return 1;
        }
        
    }

    public class CandidateDetails
    {
        public int Cid{get;set;}
        public string Cname{get;set;}
    }
    class Program
    {
        static void Main()
        {
           CandidateDetails obj=new CandidateDetails();
           obj.Cid=1233;
           obj.Cname="deepa";

           CandidateList candidateList = new CandidateList();
           int x = candidateList.CandidateName(obj);

           if(x==1)
           {
               Console.WriteLine("one record is added");
           }
        }
    }
}
