using System;
using System.Collections.Generic;

namespace DictionaryA.INSERT
{
    public class Subjects{
         public static void Main(string[] args){

            Dictionary<string, string> myDict = new Dictionary<string, string>(); //create dictionary 
            myDict.Add("Language", "English"); //adding key/value pair in dictionary
            myDict.Add("Maths", "Algebra");
            myDict.Add("Chemistry", "SolidState");

            Console.WriteLine("Dictionary before deletion");
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            myDict.Remove("Chemistry"); // deletion of a key 

            Console.WriteLine("Dictionary After deletion");
            foreach (KeyValuePair<string, string> kvp in myDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
        }
    }
}