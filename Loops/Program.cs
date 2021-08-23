using System;
using System.Text;
namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("Taazaa company");
            str.Replace("company", "Technology");
            Console.WriteLine(str);
        }
    }
}
