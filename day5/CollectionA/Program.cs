using System;
using CollectionA.Models1;
using System.Collections;

namespace CollectionA
{
    class Program
    {
        static void Main()
        {
            var list1 = new Area();
            var list2 = list1.Sides();
            int count = list2.Count;
            for (int i=0;i<count;i++)
            {
                Console.WriteLine(list1[i].Triangle+" "+list2[i].Rectangle);
            }
        }
    }
}
