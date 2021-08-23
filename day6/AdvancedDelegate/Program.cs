using System;
using AdvancedDelegate.Airthemetic;
delegate void AirthemticDelegate(double D1, double D2);
namespace AdvancedDelegate
{
    class Program
    {
        public static void Main()
        {
            AirthemticDelegate Obj = new AirthemticDelegate(AirthematicOperation.Addition); //using delegate
            //Obj.Invoke(5,4);  //invoke function will addition function  
            //Obj+=AirthematicOperation.Addition;
            Obj.Invoke(2,3);
            //LAMBDA FUNCTION
           AirthemticDelegate myObj =(double d1, double d2)=> //lamda function
           {
               Console.WriteLine(d1*d2);
           };
           //ANONYMOUS METHOD
           AirthemticDelegate myObj1 = delegate (double d1, double d2) // Anonymous function
           {
               Console.WriteLine(d1/d2);
           };
           myObj(10,5);
           myObj1(3,2);
        }
    }
}
