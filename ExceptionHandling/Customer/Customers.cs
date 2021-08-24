using System;
namespace ExceptionHandling.Customer
{
    //Exception class in c# is a base is calss exception handling which can handled all the exceptions
    // AirthemeticException is a base class of DivideByZeroException, that's why base class ca handled drive class exception
    public class Customers
    {
        int result;
        Customers()
        {
            result=0;
        }
        public void getdata(int m, int n)
        {
            try
            {
                result = m/n;
            }
            catch(DivideByZeroException exc)
            {
                Console.WriteLine("yes, Exception is Handled");
            }
            finally
            {
                Console.WriteLine(result);
            }
        }
    }
}