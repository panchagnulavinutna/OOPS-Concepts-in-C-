using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message) {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

}
