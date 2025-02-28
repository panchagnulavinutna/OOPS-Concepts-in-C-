using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Student
    {
        private string name = "";
        private decimal rollNo;
        public Student(string name, decimal rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid name. Name cannot be empty.");
                }
            }
        }
        public decimal RollNo
        {
            get { return rollNo; }
            set
            {
                if (value > 0)
                {
                    rollNo = value;
                }
                else
                {
                    Console.WriteLine("Invalid Roll Number. Must be positive.");
                }
            }
        }

        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Name: {Name}, Roll Number: {RollNo}");
        }
    }
}
