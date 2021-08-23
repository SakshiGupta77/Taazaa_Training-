using System.Collections;
using System;
using System.Collections.Generic;
namespace day6.Collections
{
    public class Candidates
    {
        public string addCandidatesName()
        { 
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Sakshi"); //boxing
            arrayList.Add("Sakshi Gupta");
            string Name = (string)arrayList[1]; //unboxing
            //Console.WriteLine(Name);
            return Name;
    
    }         
    public void addCandidatesNames()
        { 
            List<string> Obj = new List<string>();
            Obj.Add("Sakshi");
            Obj.Add("Sakshi Gupta");
           if(Obj.Contains("Sakshi Gupta"))
           {
               Console.WriteLine("Found");
           }
           else
           {
               Console.WriteLine(" Not Found");
           }
        }
}
}