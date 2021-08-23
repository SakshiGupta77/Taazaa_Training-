using System;
using Assignment.Taazaa;
using System.Collections.Generic;
namespace Assignment.Model
{
    public class Contacts
    {
        public List<Details> StudentDetails()
        {
            List<Details> Name =  new List<Details>();
            {
                Name.Add(new Details{
                    id = 101,
                    name = "Sakshi Gupta",
                    phoneNo = 8757654343
                });
                Name.Add(new Details{
                    id = 102,
                    name = "Abhinav Gupta",
                    phoneNo = 2345667
                });
                Name.Add(new Details{
                    id = 103,
                    name = "AArush Gupta",
                    phoneNo = 1234564
                });
                return Name;
            }
        }
    }
}