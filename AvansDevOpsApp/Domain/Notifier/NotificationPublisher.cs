using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Notifier
{
    public class NotificationPublisher : INotificationPublisher
    {
        public List<AbstractPerson> Observers = new List<AbstractPerson>();

        public NotificationPublisher() { }
        public void NotifySubscribers(string eventType,string notification)
        {
            Observers.ForEach(observer => observer.Update(eventType,notification));
        }

        public void Subscribe(AbstractPerson subscriber)
        {
            // One person can not subscribe to a single Notification publisher at once, so first check if the person already exists.

            if (Observers.Count(person => person == subscriber) > 0) throw new ArgumentOutOfRangeException();

            Observers.Add(subscriber);
        }

        public void Unsubscribe(AbstractPerson subscriber)
        {
            Observers.Remove(subscriber);
        }
    }
}
