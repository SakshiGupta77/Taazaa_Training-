using System;
using day8.Models;
using day8.Models2;
using System.Collections.Generic;
namespace day8
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactList Obj = new ContactList();
            Obj.createContact(); 
            List<Contact> obj1 = Obj.createContact();
            foreach(var i in obj1)
            {
                Console.WriteLine(i.Cid+" "+i.Cname);
            }
        }
    }
}
