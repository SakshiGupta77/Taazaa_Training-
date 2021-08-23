using System;
using day8.Models;
using System.Collections.Generic;
namespace day8.Models2
{
    public class ContactList
    {
        List<Contact> Object; //Not yet memory is allocated
        public ContactList() // if object of class is created then memory is take place from list
        {
            Object = new List<Contact>();
        }
        public List<Contact> createContact() // it is a member function
        {
            Object.Add(new Contact{
                Cid=101,
                Cname = "Sakshi Gupta"
            });
            Object.Add(new Contact{
                Cid=1033,
                Cname = "Abhinav Gupta"
            });
            return Object;
        }
    }
}