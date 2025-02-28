using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class ErrorCategoryLogger : ILogger
    {
        private readonly ILogger _logger;
        public ErrorCategoryLogger(ILogger logger) {
            _logger = logger;
        }
        public void Log(string message) {
            _logger.Log($"[ERROR] {message}"); 
        }
    }

}
