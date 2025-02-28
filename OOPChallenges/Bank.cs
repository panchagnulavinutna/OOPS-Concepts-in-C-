using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Bank
    {
        public string AccountHolder { 
            get;
            set; 
        }
        public double Balance { 
            get;
            set;
        }
        public static double InterestRate { 
            get;
            private set;} = 5.0;
        public Bank(string accountHolder, double balance) { 
            AccountHolder = accountHolder; Balance = balance; 
        }
        public static void SetInterestRate(double rate) { 
            InterestRate = rate; 
        }
        public void Display() {
            Console.WriteLine($"{AccountHolder} - Balance: {Balance}, Interest Rate: {InterestRate}%"); 
        }
    }

}

