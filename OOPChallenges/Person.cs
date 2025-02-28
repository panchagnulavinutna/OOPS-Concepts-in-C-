using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Person
    {
        public void Show() { 
            Console.WriteLine("This is a person.");
        }
    }
    public class Student1 : Person
    {
        public void Study() { 
            Console.WriteLine("Student is studying.");
        }
    }


}
