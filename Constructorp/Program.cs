using System;
class Program {

    public static string name;
    public static int num;
    private Program() { // Creating private Constructor
  
        Console.WriteLine("this is Private Constructor");
    }
    public Program(string x, int y) {    // Default Constructor

        name = x;
        num = y;
    }
}
class Taazaa {
    static void Main() {

        Program obj = new Program("Sakshi", 52);// only default constructor will call
        Console.WriteLine(Program.name + ", " + Program.num);
    }
}