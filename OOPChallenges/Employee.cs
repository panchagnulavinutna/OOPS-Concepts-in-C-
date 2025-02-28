using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{ 
    public class Employee
    {
        public string Name { 
            get; 
            set;
        }
        public double Salary { 
            get;
            set;
        }
        public Employee(string name, double salary) {
            Name = name; 
            Salary = salary;
        }
        public void DisplayInfo() { 
            Console.WriteLine($"Name: {Name}, Salary: {Salary}"); 
        }
    }
    public class Manager1 : Employee
    {
        public double Bonus { 
            get; 
            set;
        }
        public Manager1(string name, double salary, double bonus) : base(name, salary) {
            Bonus = bonus; 
        }
        public void DisplayManagerInfo() {
            DisplayInfo(); Console.WriteLine($"Bonus: {Bonus}"); 
        }
    }

}
