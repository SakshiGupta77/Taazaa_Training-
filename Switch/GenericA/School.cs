using System;
using System.Collections.Generic;
namespace Switch.GenericA {
    public class School{ 
        public static void Main(){
            List<string> Name = new List<string>();
            for(int i=0;i<3;i++)
            {
                switch(i)
                {
                    case 1:
                    Name.Add("Sakshi");
                    Name.Add("Gupta");
                    Console.WriteLine("Student name added");
                    break;
                    case 2:
                    if(Name.Contains("sakshii"))
                    {
                     Console.WriteLine("sakshii is found");   
                    }
                    else
                    {
                     Console.WriteLine("sakshii is not found");
                    }
                    break;
                }
            }
        }       
    }
}