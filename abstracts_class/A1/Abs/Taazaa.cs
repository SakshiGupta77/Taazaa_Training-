using System;
namespace A1.Abs
{
    class Perimeter
    {
        public enum shapes { // declaring enum
             circle, square  //data members 
        }
        public void peri(int v1, shapes s1) {
            if (s1==0) {  //checking shape is zero or one
                Console.WriteLine("circumference of circle is : "+ 2*3.14*v1);
            }
            else {
             Console.WriteLine("perimeter of square is : "+4*v1);   
            }
        }
    }
    class program {
        static void Main(string[] args) {
            var obj = new Perimeter();
            obj.peri(1,Perimeter.shapes.circle);
            obj.peri(2,Perimeter.shapes.square);
        }
    }
}