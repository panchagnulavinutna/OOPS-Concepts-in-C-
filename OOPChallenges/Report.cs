using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class Report : IPrintable, ISerializable
    {
        public void PrintDetails() { Console.WriteLine("Printing report..."); }
        public void SaveToFile() { Console.WriteLine("Saving report to file..."); }
    }

}


