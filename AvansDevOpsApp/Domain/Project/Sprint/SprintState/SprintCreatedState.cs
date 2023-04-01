using AvansDevOpsApp.Domain.Project.Backlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Sprint.SprintState
{
    public class SprintCreatedState : ISprintState
    {
        public Sprint SprintContext;
        public SprintCreatedState(Sprint sprintContext) 
        { 
            SprintContext = sprintContext;
        }
        public void AddBacklogItem(BacklogItem newItem)
        {
            SprintContext.SprintBacklogItems.Add(newItem);
        }

        public void RemoveBacklogItem(string itemName)
        {
            var itemToRemove = SprintContext.SprintBacklogItems.Find((item) => itemName == item.Name);
            
            if(itemToRemove != null)
            {
                SprintContext.SprintBacklogItems.Remove(itemToRemove);
            }
        }

        public void RemoveBacklogItem(BacklogItem backlogItem)
        {
            SprintContext.SprintBacklogItems.Remove(backlogItem);
        }

        public void SetEndTime(DateTime time)
        {
            SprintContext.EndTime = time;
        }

        public void SetName(string newName)
        {
            SprintContext.Name = newName; 
        }

        public void UpdateBacklogItem(BacklogItem newBacklogItem, string backlogItemToChange)
        {
            var itemToUpdate = SprintContext.SprintBacklogItems.Find((item) => backlogItemToChange == item.Name);
            var index = SprintContext.SprintBacklogItems.FindIndex((item) => backlogItemToChange == item.Name);
            if(itemToUpdate != null)
            {
                SprintContext.SprintBacklogItems.Insert(index, itemToUpdate);
            }    
        }
    }
}
