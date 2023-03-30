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
            items.OrderBy(i => i.Name);
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
