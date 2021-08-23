using System;

namespace CollectionA.Models1
{
    public class Shape
    {
        public string Triangle{get;set;}
        public string Rectangle{get;set;}

        internal object Sides()
        {
            throw new NotImplementedException();
        }
    }
}