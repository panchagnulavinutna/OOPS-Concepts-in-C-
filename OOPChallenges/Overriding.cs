using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Overriding
    {
        public string Brand
        {
            get;
            set;
        }
        public int Speed
        {
            get;
            set;
        }
        public Overriding(string brand, int speed)
        {
            Brand = brand; Speed = speed;
        }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
    }
}
    public class Car3 : Overriding
    {
        public int Doors { 
            get;
            set;
        }
        public Car3(string brand, int speed, int doors) : base(brand, speed) { 
            Doors = doors;
        }
        public override void DisplayInfo() {
            base.DisplayInfo(); Console.WriteLine($"Doors: {Doors}");
        }
    }
    public class Bike3 : Overriding
    {
        public bool HasGear {
            get;
            set;
        }
        public Bike3(string brand, int speed, bool hasGear) : base(brand, speed) { 
            HasGear = hasGear; 
        }
        public override void DisplayInfo() { 
            base.DisplayInfo(); Console.WriteLine($"Has Gear: {HasGear}"); 
        }
    }

}
