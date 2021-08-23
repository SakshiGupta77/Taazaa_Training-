namespace Mislleneous.IT
{
    public class Taazaa
    {
        double Salary;
        readonly int EmpId;
        static string Cafeteria;

        public Taazaa(int eid, double sal) //static constructor
        {
            Salary = sal;
            EmpId = eid;
        }
        static Taazaa()  // static function (can not give parameter)
        {
            Cafeteria = "100sqft";
        }
        public int Employeeid() //member function
        {
            return EmpId;
        }
        public static string CoffeeHouse() //static function
        {
            return Cafeteria;
        }
        public double EmployeeSalary() //member function
        {
            return Salary;
        }
    }
}
