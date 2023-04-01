using AvansDevOpsApp.Domain.Project.Backlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Sprint.SprintState
{
    public class SprintCancelledState : ISprintState
    {
        public void AddBacklogItem(BacklogItem newItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveBacklogItem(string itemName)
        {
            throw new NotImplementedException();
        }

        public void RemoveBacklogItem(BacklogItem backlogItem)
        {
            throw new NotImplementedException();
        }

        public void SetEndTime(DateTime time)
        {
            throw new NotImplementedException();
        }

        public void SetName(string newName)
        {
            throw new NotImplementedException();
        }

        public void UpdateBacklogItem(BacklogItem newBacklogItem, string backlogItemToChange)
        {
            throw new NotImplementedException();
        }
    }
}
