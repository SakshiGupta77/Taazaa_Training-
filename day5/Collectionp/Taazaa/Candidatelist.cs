using System.Collections;
using System.Collections.Generic;
using Collectionp.Models;
// provding a new approach using generics
namespace Collectionp.Taazaa
{
    public class Candidatelist
    {
        public ArrayList Candidetails()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Salman"); 
            arrayList.Add("divya"); 
            arrayList.Add("geetika"); 
            arrayList.Add("Sachin"); 
            arrayList.Add("Sakshi"); 
            return arrayList;
        }
        public List<Candidate> Candidatedetails()
        {
           List<Candidate> obj = new List<Candidate>();
           obj.Add(new Candidate{
               Cid=101,
               Cname = "sakshi"
           });
           
           obj.Add(new Candidate{
               Cid=102,
               Cname = "salaman"
           });
           return obj;
        }
    }
}