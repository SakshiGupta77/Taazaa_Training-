using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LINQ
{
    class Program
    {
        public int ID;
        public string Name;
        public int salary;
        static void Main()
        {
            List<Program> list = new List<Program>
            {
                new Program{ID=1,Name="jhon",salary=2500},
                new Program{ID=2,Name="Sena",salary=1500},
                new Program{ID=3,Name="Max",salary=5500},
                new Program{ID=4,Name="Gen",salary=3500}
            };

            // The "Where" LINQ operator filters a sequence
            var highEarners = list.Where(p => p.salary > 3000);

            foreach (var ele in highEarners)
            {
                Console.WriteLine(ele.Name);
            }
        }
    }
}
