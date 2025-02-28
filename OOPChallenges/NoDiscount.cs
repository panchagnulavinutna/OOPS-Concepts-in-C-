using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal total) { return total; }
    }
}
