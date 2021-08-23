using System;
using day9.ContactList;
using day9.Models;
using System.Collections.Generic;
namespace day9
{
    class Program
    {
        static void Main()
        {
            Contact Obj1 = new Contact();
            Obj1.id=101;
            Obj1.name="Sakshi";
            
            Contact Obj2 = new Contact();
            Obj2.id=102;
            Obj2.name="Sachin";

            ContactsList ObjList = new ContactsList();
            ObjList.creatContact(Obj1);
            ObjList.creatContact(Obj2);
            List<Contact> temp = ObjList.DisplayList();
            foreach(var item in temp)
            {
                Console.WriteLine(item.id+" "+item.name);
            }
        }
    }
}
