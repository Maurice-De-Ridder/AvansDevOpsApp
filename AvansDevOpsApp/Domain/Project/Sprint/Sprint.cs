using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Sprint.SprintState;
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
        public ISprintState State;
        public ISprintTypeStrategy SprintStrategy;

        public Sprint(string name, DateTime endTime, INotificationPublisher publisher, ISprintTypeStrategy typeStrategy)
        {
            this.Publisher = publisher;
            this.Name = name;
            this.EndTime = endTime;
            this.SprintStrategy = typeStrategy;
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

        public void ChangeState(ISprintState sprintState)
        {
            State = sprintState;
            Publisher.NotifySubscribers("Changed", "veranderd");
        }

        public void SetName(string newName)
        {
            State.SetName(newName);
        }

        public void SetEndTime(DateTime time)
        {
            State.SetEndTime(time);
        }

        public void AddBacklogItem(BacklogItem newItem)
        {
            State.AddBacklogItem(newItem);
        }

        public void RemoveBacklogItem(string itemName)
        {
            State.RemoveBacklogItem(itemName);
        }

        public void RemoveBacklogItem(BacklogItem backlogItem)
        {
            State.RemoveBacklogItem(backlogItem);
        }

        public void UpdateBacklogItem(BacklogItem newBacklogItem, string backlogItemToChange)
        {
            State.UpdateBacklogItem(newBacklogItem, backlogItemToChange);
        }

        public void FinishSprint()
        {
            this.SprintStrategy.FinishSprint();
        }
    }
}
