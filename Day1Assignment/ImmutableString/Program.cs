using System;

namespace ImmutableString
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "Taazaa";	
            string string2 = "Company";
            if (String.Compare(string1, string2) == 0) //by using compare method
            {
                Console.WriteLine(string1 + " and " + string2 + " are equal strings.");
            }
            else 
            {
                Console.WriteLine(string1 + " and " + string2 + " are not equal strings.");
            }
        }
    }
}
