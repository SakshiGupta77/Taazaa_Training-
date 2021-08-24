using System;
//using System.Text;
namespace StringMethods
{
    class Program
    {
        static void Main()
        {
            string str1 = " Hello World";
            string str2 = (string)str1.Clone(); //used to return a reference to this instance of String.
            Console.WriteLine("Clone " + str2);

            if (String.Compare(str1, str2) == 0) //by using compare method 
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal strings.");
            } 
            else 
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal strings.");
            }

            string str3 = string.Copy(str1);  // copy str1 in str3
            Console.WriteLine("Copy " + str3);

            Console.WriteLine("Concat " + string.Concat(str1, str2)); // concatenate of two string

            Console.WriteLine("Contains  "+str1.Contains(str2)); // return bool 
            Console.WriteLine(str3);
            Console.WriteLine("Equals "+ str1.Equals(str3)); // return bool
        }
    }
}
