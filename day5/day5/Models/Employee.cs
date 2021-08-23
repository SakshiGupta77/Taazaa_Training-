namespace day5.Models
{
    public class Employee
    {
        private int Eid; //(laptop)
        private double Salary;

        public int Employee_id // properties (laptop bag)
        {
            get //(access)
            {
                return Eid;
            }
            set //(assign)  
            {
                Eid = value; //value is a reserve keyword to assign  th data to the variable
            }
        }
        public double Salary_id // properties (laptop bag)
        {
            get //(access)
            {
                return Salary;
            }
            set //(assign)  
            {
                Salary = value; //value is a reserve keyword to assign  th data to the variable
            }
        }


    }
}