using System;

namespace JaggedArray
{
    class Program
    {
        static void Main()
        {
            int[][] j_rr = new int[2][]; //jagged array declaration of 2 element
            j_rr[0] = new int[] {1,2,3,4,5}; 
            j_rr[1] = new int[] {2,3,4,5};

            for(int n=0;n<j_rr.Length;n++)
            {
                Console.WriteLine("Row :"+n);
                for(int k=0;k<j_rr[n].Length;k++)
                {
                    Console.WriteLine("{0} "+ j_rr[n][k]);
                }
                Console.WriteLine();
            }
        }
    }
}
