using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
    public class Dog : Animal
    {
        public override void MakeSound() { 
            Console.WriteLine("Dog barks: Woof Woof!"); 
        }
    }
    public class Cat : Animal
    {
        public override void MakeSound() { 
            Console.WriteLine("Cat meows: Meow Meow!"); 
        }
    }


}
