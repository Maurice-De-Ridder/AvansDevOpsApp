using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Sprint
{
    public class Sprint : ISprint
    {
        public INotificationPublisher publisher = new NotificationPublisher();

        public string name;
        public Sprint(string name)
        {
            this.name = name;
        }
        public void Subscribe(string eventType,AbstractPerson person)
        {
            this.publisher.subscribe(eventType,person);
        }

        // Verander dit bij implementatie van echte states
        public void ChangeStateCancelled()
        {
            this.publisher.notifySubscribers("Cancelled", name + " is cancelled");

        }


    }
}
