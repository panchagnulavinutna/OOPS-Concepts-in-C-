using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Product
    {
        public string Name {
            get; 
            set; 
        }
        public double Price {
            get; 
            set; 
        }
        public Product(string name, double price) { 
            Name = name; 
            Price = price; 
        }
        public virtual double GetDiscountedPrice() { 
            return Price;
        }
        public void Display() { 
            Console.WriteLine($"Product: {Name}, Price: {Price:C}, Discounted Price: {GetDiscountedPrice():C}"); 
        }
    }
    public class ElectronicProduct : Product
    {
        public ElectronicProduct(string name, double price) : base(name, price) { }
        public override double GetDiscountedPrice() {
            return Price * 0.9;
        } 
    }
    public class ClothingProduct : Product
    {
        public ClothingProduct(string name, double price) : base(name, price) { }
        public override double GetDiscountedPrice() {
            return Price * 0.8;
        } 
    }
}
