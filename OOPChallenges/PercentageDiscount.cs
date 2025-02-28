using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class PercentageDiscount : IDiscountStrategy
    {
        private readonly decimal _percentage;
        public PercentageDiscount(decimal percentage) { 
            _percentage = percentage;
        }
        public decimal ApplyDiscount(decimal total) { 
            return total - (total * _percentage / 100);       
        }
    }
}
