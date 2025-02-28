using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPChallenges
{
    public class NotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();
        public void Subscribe(INotificationObserver observer) { 
            observers.Add(observer);
        }
        public void Unsubscribe(INotificationObserver observer) { 
            observers.Remove(observer);
        }
        public void Notify(string message)
        {
            foreach (var observer in observers) { 
                observer.Update(message); 
            }
        }
    }
}
