using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Notifier
{
    public interface INotificationPublisher
    {
        public void subscribe(string eventType,AbstractPerson person);

        public void unsubscribe(string eventType, AbstractPerson person);

        public void notifySubscribers(string eventType, string notification);
 



    }
}
