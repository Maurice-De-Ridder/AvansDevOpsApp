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
            Observers.Add(subscriber);
        }

        public void Unsubscribe(AbstractPerson subscriber)
        {
            Observers.Remove(subscriber);
        }
    }
}
