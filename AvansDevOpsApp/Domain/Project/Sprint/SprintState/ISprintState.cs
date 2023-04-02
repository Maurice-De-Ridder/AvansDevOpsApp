using AvansDevOpsApp.Domain.Project.Backlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Sprint.SprintState
{
    public interface ISprintState
    {
        public void SetName(string newName);
        public void SetEndTime(DateTime time);
        public void AddBacklogItem(BacklogItem newItem);
        public void RemoveBacklogItem(string itemName);
        public void RemoveBacklogItem(BacklogItem backlogItem) ;
        public void UpdateBacklogItem(BacklogItem newBacklogItem, string backlogItemToChange) ;
    }
}
