using System;
using System.Collections.Generic;
using day9.Models;
namespace day9.ContactList
{
    public class ContactsList
    {
        List<Contact> ObjectList;
        public ContactsList()
        {
            ObjectList = new List<Contact>();
        }
        public void creatContact(Contact ObjectContact)
        {
            ObjectList.Add(ObjectContact);  
        }
        public List<Contact> DisplayList()
        {
            return ObjectList;
        }
    }
}