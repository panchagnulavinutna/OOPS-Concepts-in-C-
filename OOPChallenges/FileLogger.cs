using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class FileLogger : ILogger
    {
        public void Log(string message) { 
            Console.WriteLine($"Logging to file: {message}"); 
        }
    }

}
