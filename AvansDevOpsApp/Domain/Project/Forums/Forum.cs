using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Forums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Forum
{
    public class Forum : IForum
    {
        public List<Discussion> Discussions = new List<Discussion>();
        public Forum() { }
        public void AddDiscussion(BacklogItem backlogItem, INotificationPublisher notificationPublisher, AbstractPerson creator)
        {
            Discussion discussionToAdd = new Discussion(notificationPublisher);

            // add the backlog item reference
            discussionToAdd.ReferencedBacklogItem = backlogItem;

            // check if there is already a discussion for this backlog item
            if (Discussions.Count(discussion => discussion.ReferencedBacklogItem == backlogItem) > 0) throw new ArgumentOutOfRangeException();

            // make sure the creator subscribes to the new message events
            notificationPublisher.Subscribe(creator);

            // add the discussion to the list
            Discussions.Add(discussionToAdd);
            
        }

        public void RemoveDiscussion(BacklogItem backlogItems)
        {
            throw new NotImplementedException();
        }
    }
}
