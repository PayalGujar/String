using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String.Generic_Collection
{
    public class Employee
    {
        public int Salary { get; set; }
        public string Name { get; set; }
    }

    public class CheckSalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if(x.Salary > y.Salary)
            {
                return 1;
            }
            else if(x.Salary < y.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class EmpoyeeIcomparerExample
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee() { Salary = 30000, Name = "Ketki" };
            Employee e2 = new Employee() { Salary = 40000, Name = "Aishwarya" };

            CheckSalary c1 = new CheckSalary();
            int res= c1.Compare(e1, e2);
            if (res == 1)
            {
                Console.WriteLine("ketki has More salary than Aishwarya");

            }else if(res==-1)
            {
                Console.WriteLine("Ketki has less salary than aishwarya");
            }
            else
            {
                Console.WriteLine("Both Have Same Salary");
            }
        }
        
        
    }
}
