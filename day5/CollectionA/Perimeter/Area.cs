using System.Collections;
using System.Collections.Generic;
using CollectionA.Models1;
namespace CollectionA.Perimeter
{
    public class Area
    {
       public ArrayList Side()
       {
           ArrayList arrayList = new ArrayList();
           arrayList.Add("three");
           arrayList.Add("four");
           return arrayList;

       } 
       public List<Shape>Sides()
       {
           List<Shape> obj = new List<Shape>();
           obj.Add(new Shape{
               Triangle = "THREE",
               Rectangle = "FOUR"
           });
           return obj;
       }
    }
}