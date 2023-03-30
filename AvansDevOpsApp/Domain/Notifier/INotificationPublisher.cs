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
        public void Subscribe(AbstractPerson person);

        public void Unsubscribe(AbstractPerson person);

        public void NotifySubscribers(string eventType, string notification);
 



    }
}
