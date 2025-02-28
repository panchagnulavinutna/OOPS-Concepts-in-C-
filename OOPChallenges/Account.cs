using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Account
    {
        public virtual void CalculateInterest() {
            Console.WriteLine("Calculating interest in Account."); 
        }
    }
    public class SavingsAccount : Account
    {
        public sealed override void CalculateInterest() { 
            Console.WriteLine("Calculating interest in SavingsAccount.");
        }
    }
}
