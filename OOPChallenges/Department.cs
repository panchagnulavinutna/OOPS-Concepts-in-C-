using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Department
    {
        public string DeptName { 
            get; 
            set; 
        }
        public Manager Manager { 
            get;
            set;
        }
        public Department(string deptName, string managerName) { 
            DeptName = deptName; Manager = new Manager(managerName);
        }
        public Department ShallowCopy() { 
            return (Department)this.MemberwiseClone(); 
        }
        public Department DeepCopy() { 
            return new Department(this.DeptName, this.Manager.Name); 
        }
        public void Display() { 
            Console.WriteLine($"Department: {DeptName}, Manager: {Manager.Name}");
        }
    }

}
