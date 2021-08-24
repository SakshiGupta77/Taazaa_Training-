using System;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            int  i,l; 	
            Console.Write("Input the string : ");
            str1 = Console.ReadLine();
            
            l=str1.Length;
            string[] str2=new string[l];

            /* Copies string1 to string2 character by character */
            i=0;
            while(i<l)
            {
                string tmp=str1[i].ToString();
                str2[i] = tmp;
                i++;
            }
            Console.Write("\nThe First string is : {0}\n", str1);
        }
    }
}
