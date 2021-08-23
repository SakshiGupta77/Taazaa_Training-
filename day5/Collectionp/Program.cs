using System;
using Collectionp.Taazaa;
using System.Collections;

namespace Collectionp
{
    class Program
    {
        static void Main()
        {
            /* var obj = new Candidatelist();
            var arrayList = obj.Candidetails();
            int count = arrayList.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(arrayList[i]);
            } */
            var objlist = new Candidatelist();
            var list = objlist.Candidatedetails();
            int count = list.Count;
            for(int i=0;i<count;i++)
            {
                Console.WriteLine(list[i].Cid+ " "+list[i].Cname);
            } 
        }
    }
}
