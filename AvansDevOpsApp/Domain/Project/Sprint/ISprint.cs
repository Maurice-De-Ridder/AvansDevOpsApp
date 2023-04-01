using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Sprint.SprintState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AvansDevOpsApp.Domain.Project.Sprint
{
    public interface ISprint
    {
        public void Subscribe(AbstractPerson person);
        public void ChangeStateCancelled();

        public void ChangeState(ISprintState sprintState);

        public void SetName(string newName);
        public void SetEndTime(DateTime time);
        public void AddBacklogItem(BacklogItem newItem);
        public void RemoveBacklogItem(string itemName);
        public void RemoveBacklogItem(BacklogItem backlogItem);
        public void UpdateBacklogItem(BacklogItem newBacklogItem, string backlogItemToChange);
    }
}
//public INotificationPublisher Publisher;
//public string Name;

//public List<BacklogItem> SprintBacklogItems = new List<BacklogItem>();
//public DateTime Created = DateTime.Now;
//public DateTime EndTime;
//public ISprintState State;
