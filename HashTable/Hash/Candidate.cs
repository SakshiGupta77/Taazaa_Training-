using System;
using System.Collections;
namespace HashTable.Hash
{
    public class Candidate
    {
        public static void Main(String[] args)
        {
            Hashtable table = new Hashtable(); // Creating a Hashtable

            table.Add("0", "Dell");  // Adding elements in Hashtable
            table.Add("1", "Hp");
            table.Add("2", "MacBook");
            table.Add("3", "Lenovo");

            table["1"] = "Ace";      // update value of 1 key
            table.Remove("2");       // remove 2 key
            ICollection collections = table.Keys; // Get a collection of the keys.
            foreach(string i in collections) 
            {
                Console.WriteLine(i + " " + table[i]);
            }
        }
    }
}