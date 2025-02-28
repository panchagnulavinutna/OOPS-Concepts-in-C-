using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class ShoppingCart
    {
        private IDiscountStrategy _discountStrategy;
        public ShoppingCart(IDiscountStrategy discountStrategy) { 
            _discountStrategy = discountStrategy;
        }
        public void SetDiscountStrategy(IDiscountStrategy discountStrategy) { 
            _discountStrategy = discountStrategy;
        }
        public decimal GetFinalPrice(decimal total) { 
            return _discountStrategy.ApplyDiscount(total);
        }
    }
}
