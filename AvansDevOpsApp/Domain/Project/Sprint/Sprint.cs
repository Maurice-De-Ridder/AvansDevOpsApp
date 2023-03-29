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
        public INotificationPublisher Publisher;
        public string Name;
        public Sprint(string name,INotificationPublisher publisher)
        {
            this.Publisher = publisher;
            this.Name = name;
        }
        public void Subscribe(AbstractPerson person)
        {
            this.Publisher.Subscribe(person);
        }

        // Verander dit bij implementatie van echte states
        public void ChangeStateCancelled()
        {
            this.Publisher.NotifySubscribers("Cancelled", Name + " is cancelled");

        }


    }
}
