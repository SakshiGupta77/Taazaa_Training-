using System;
namespace Abstraction.Models
{
    public class Shapes
    {
        abstract class shape
    {
        public abstract double area();
    }
    class circle : shape
    {
        public double radius;
        public circle(double r)
        {
            radius = r;
        }
        public override double area()
        {
            return(3.14*radius*radius);
        }
    }
    class square :shape
    {
        public double side;
        public square(double s)
        {
            side = s;
        }
        public override double area()
        {
            return(side*side);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var obj1 = new circle(5.0);
            var obj2 = new square(2.0);
            Console.WriteLine(obj1.area()+" "+obj2.area());
        } 
    }
    }
}