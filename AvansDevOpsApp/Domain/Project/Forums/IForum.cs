using AvansDevOpsApp.Domain.Project.Backlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Forum
{
    public interface IForum
    {
        public void AddDiscussion(BacklogItem backlogItem);
        public void RemoveDiscussion(BacklogItem backlogItems);


    }
}
