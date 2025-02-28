using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager _instance;
        private static readonly object _lock = new object();
        public string ConfigValue { 
            get;
            set;
        }
        private ConfigurationManager() { 
            ConfigValue = "Default Configuration"; 
        }
        public static ConfigurationManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null) _instance = new ConfigurationManager();
                }
            }
            return _instance;
        }
        public void ShowConfig() { 
            Console.WriteLine($"Configuration: {ConfigValue}"); 
        }
    }

}
