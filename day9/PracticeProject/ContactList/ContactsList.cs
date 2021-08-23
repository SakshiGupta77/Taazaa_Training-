using System;
using PracticeProject.Model;
using System.Collections.Generic;
namespace PracticeProject.ContactList
{
    public class ContactsList:Icontact
    {
        List<Contact> ObjectList;
        public ContactsList() // constructor
        {
            ObjectList = new List<Contact>();
        }
        public void ContactDetails(Contact ObjectContact)
        {
            ObjectList.Add(ObjectContact);
        }
        public List<Contact> DisplayList()
        {
            return ObjectList;
        }

    }
}