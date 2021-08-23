using System;

namespace ExceptionHandling
{
    class Program : System.Exception
    {
        static void Main(string[] args)
        {
            int[] array = {11,22,33,44,55,66}; // 5 index array
            for(int i=0; i<array.Length;i++)
            {
                Console.WriteLine(array[i]); 
            }

            try
            {
                Console.WriteLine(array[9]); //access invalid index
            }
            catch(IndexOutOfRangeException e) //(IndexOutOfRangeException) this is the error occured 
            {
                Console.WriteLine("An Exception is Occured :"+e.Message);
            }
        }
    }
}
