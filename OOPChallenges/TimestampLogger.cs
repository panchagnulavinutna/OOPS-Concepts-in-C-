using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class TimestampLogger : ILogger
    {
        private readonly ILogger _logger;
        public TimestampLogger(ILogger logger) {
            _logger = logger;
        }
        public void Log(string message) {
            _logger.Log($"[{DateTime.Now}] {message}");
        }
    }

}
