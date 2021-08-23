using System;
using AdvGenerics.TrainingList;
using AdvGenerics.Models;
using System.Collections.Generic;

namespace AdvGenerics
{
    class Program
    {
        static void Main()
        {
            var Object = new TaazaaTrainingList();
            List<Details> temp = Object.TrainingList();
            int count = temp.Count;
            for(int i=0;i<count;i++){
                Console.WriteLine(temp[i].PhoneNumber+" "+temp[i].Email);
            }
        }
    }
}
