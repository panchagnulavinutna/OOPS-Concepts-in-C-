﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public interface ISwimmable
    {
        void Swim();
    }
    public class Duck : IFlyable, ISwimmable
    {
        public void Fly() { 
            Console.WriteLine("Duck is flying!"); 
        }
        public void Swim() { 
            Console.WriteLine("Duck is swimming!");
        }
    }
}
