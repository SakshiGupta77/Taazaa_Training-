using System.Collections.Generic;
using PracticeProject.Model;
namespace PracticeProject.ContactList
{
    public interface Icontact
    {
         void ContactDetails(Contact ObjectContact);
         List<Contact> DisplayList();
    }
}