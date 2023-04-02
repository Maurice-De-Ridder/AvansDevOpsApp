using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog;
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

        public List<BacklogItem> SprintBacklogItems= new List<BacklogItem>();
        public DateTime Created = DateTime.Now;
        public DateTime EndTime;

        public Sprint(string name, DateTime endTime, INotificationPublisher publisher)
        {
            this.Publisher = publisher;
            this.Name = name;
            this.EndTime= endTime;
        }
        public void Subscribe(AbstractPerson person)
        {
            this.Publisher.Subscribe(person);
        }

        public void ChangeStateCancelled()
        {
            this.Publisher.NotifySubscribers("Cancelled", Name + " is cancelled");

        }


    }
}
