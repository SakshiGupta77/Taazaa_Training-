using System.Collections.Generic;
using AdvGenerics.Models;
namespace AdvGenerics.TrainingList
{
    public class TaazaaTrainingList
    {
        public List<Details> TrainingList()
        {
            List<Details> Obj = new List<Details>();
            Obj.Add(new Details{
               Email="Sakshi@123.com",
               PhoneNumber=987643321
            });
            Obj.Add(new Details{
                Email="Abhi@123.com",
                PhoneNumber = 345678
            });
            return Obj;
        }
    }
}