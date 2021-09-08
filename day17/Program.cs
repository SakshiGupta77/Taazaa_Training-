using System;
delegate void delegatename(string s1, string s2);
namespace day17
{
    /* class Delegatep
    {
        public string name()
            return "sakshi";
        }
        public string sname()
        {
            return "Gupta";
        }
        public int phone()
        {
            return 12345;
        }
    } */
    class Program
    {
        public static void Main()
        {
            //Delegatep delegateobj = new Delegatep();
            //delegatename dobj = new delegatename(delegateobj.name); 
            //string temp = dobj.Invoke();
            //dobj += delegateobj.sname;
            //string temp1= dobj.Invoke();
            //Console.WriteLine(temp+" "+temp1);
            delegatename dobj = delegate (string S1,string S2)
            {
                Console.WriteLine(S1+" "+S2);
            }
            dobj("Sakshi","Gupta");
        }
    }
}
