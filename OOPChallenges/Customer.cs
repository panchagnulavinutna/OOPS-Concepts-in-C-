using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }
        public override void AccessControl() {
            Console.WriteLine($"{Username} ({Role}) has limited access.");
        }
    }

}

