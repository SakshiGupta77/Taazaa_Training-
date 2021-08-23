using System;
using PracticeProject.Model;
using System.Collections.Generic;
using PracticeProject.ContactList;

namespace PracticeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact Objectcontact = new Contact();
            Objectcontact.id=222;
            Objectcontact.name = "Sakshi";

             Contact Objectcontact1 = new Contact();
            Objectcontact1.id=5555;
            Objectcontact1.name = "Sakshi Gupta";

            ContactsList ObjList = new ContactsList();
            ObjList.ContactDetails(Objectcontact);
            ObjList.ContactDetails(Objectcontact1);
            List<Contact> temp = ObjList.DisplayList();
            foreach(var item in temp)
            {
                Console.WriteLine(item.id+" "+item.name);
            }
        }
    }
}
