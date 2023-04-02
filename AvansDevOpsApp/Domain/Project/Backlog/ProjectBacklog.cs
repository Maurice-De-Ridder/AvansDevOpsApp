using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog
{
    public class ProjectBacklog : IProjectBacklog
    {
        private List<BacklogItem> items = new List<BacklogItem>();

        public INotificationPublisher Publisher;
        public ProjectBacklog(INotificationPublisher publisher) 
        { 
            this.Publisher = publisher;
        }
        
        public void Add(BacklogItem item)
        {
            this.items.Add(item);
        }

        public void ChangePos(int index, BacklogItem item)
        {
            this.items.Remove(item);
            this.items.Insert(index, item);
        }
        
        public void Remove(BacklogItem item)
        {
            this.items.Remove(item);
        }

        public List<BacklogItem> GetItems()
        {
            return this.items;
        }
        public void Subscribe(AbstractPerson p)
        {
            this.Publisher.Subscribe(p);
        }

        public INotificationPublisher GetPublisher()
        {
            return this.Publisher;
        }
    }
}
