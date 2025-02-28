using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Inheritance
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
        public Inheritance(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed}kmph");
        }
    }
    public class Car2: Inheritance
    {
        public int Doors
        {
            get;
            set;
        }
        public Car2(string brand, int speed, int doors): base(brand, speed)
        {
            Doors = doors;
        }
        public void ShowCarDetails()
        {
            DisplayInfo();
            Console.WriteLine($"Doors: {Doors}");
        }
    }
    public class Bike2: Inheritance
    {
        public bool HasGear
        {
            get;
            set;
        }
        public Bike2(string brand, int speed, bool hasgear): base(brand, speed)
        {
            HasGear = hasgear;
        }
        public void ShowBikeDetails()
        {
            DisplayInfo();
            Console.WriteLine($"HasGear: {HasGear}");
        }
    }
}
