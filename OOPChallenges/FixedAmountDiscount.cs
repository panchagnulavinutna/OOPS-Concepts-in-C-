using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private readonly decimal _amount;
        public FixedAmountDiscount(decimal amount) { 
            _amount = amount;
        }
        public decimal ApplyDiscount(decimal total) {
            return total - _amount > 0 ? total - _amount : 0;
        }
    }
}
