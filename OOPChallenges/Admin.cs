using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }
        public override void AccessControl() { 
            Console.WriteLine($"{Username} ({Role}) has access to all features."); 
        }
    }

}

