using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog
{
    public class ProjectBacklog
    {
        private List<BacklogItem> items = new List<BacklogItem>();
        public ProjectBacklog() { }
        
        public void Add(BacklogItem item)
        {
            items.Add(item);
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
        public BacklogItem GetForSprint(string name)
        {
            BacklogItem item = items.Find(i => i.Name == name);
            if (item == null)
            {
                return null;
            }
            items.Remove(item);
            return item;
        }

    }
}
