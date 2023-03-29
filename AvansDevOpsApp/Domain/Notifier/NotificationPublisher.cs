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
        public Dictionary<string,List<AbstractPerson>> Observers = new Dictionary<string, List<AbstractPerson>>();

        public NotificationPublisher() { }
        public void notifySubscribers(string eventType,string notification)
        {
            Observers[eventType].ForEach(observer => observer.update(notification));
            //throw new NotImplementedException();
        }

        public void subscribe(string eventType,AbstractPerson subscriber)
        {

            if (!this.Observers.ContainsKey(eventType))
            {
                this.Observers[eventType] = new List<AbstractPerson>();
            }
            if (!this.Observers[eventType].Contains(subscriber))
            {
                this.Observers[eventType].Add(subscriber);
            }
            else
            {
                Console.WriteLine("Subscriber already in list");
            }
            

            //implement what to do if subscriber already exists

            //throw new NotImplementedException();
        }

        public void unsubscribe(string eventType,AbstractPerson subscriber)
        {
            this.Observers[eventType].Remove(subscriber);
            //throw new NotImplementedException();
        }
    }
}
