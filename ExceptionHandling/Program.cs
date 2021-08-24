using System;
using ExceptionHandling.Customer;
namespace ExceptionHandling
{
    class Program
    {
        static void Main()
        {
            Customers customers = new Customers();
            customers.getdata(4,5);
        }
    }
}
