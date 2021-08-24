using System;

namespace _2DArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = {{1,2,3,4},
                        {5,6,7,8},
                        {9,10,11,12}};
            foreach(int i in arr)
            {
                Console.WriteLine(i+" ");
            }
            Console.WriteLine("\n");
            for (int i=0; i<arr.GetLength(0);i++)
            {
                for (int j=0; j<arr.GetLength(0);j++)
                {
                    Console.WriteLine(arr[i,j]+" ");
                }
            }
        }
    }
}
