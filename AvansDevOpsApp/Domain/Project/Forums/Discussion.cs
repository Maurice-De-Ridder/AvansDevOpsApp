using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Project.Backlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Forums
{
    public class Discussion
    {
        public BacklogItem ReferencedBacklogItem { get; set; }
        public List<Reaction> Reactions { get; set; }
        public INotificationPublisher DiscussionNotificationPublisher { get; set; }
        public Discussion(INotificationPublisher notificationPublisher) 
        {
            DiscussionNotificationPublisher = notificationPublisher;
        }
        public void AddReaction(Reaction reaction)
        {
            // make the commenter subscribe to the discussion thread.
            DiscussionNotificationPublisher.Subscribe(reaction.Person);
            // add the comment
            Reactions.Add(reaction);
            // notify all other commenters
            string reactionEventText = $"{reaction.Person} added a comment to discussion {ReferencedBacklogItem.Name}.";
            DiscussionNotificationPublisher.NotifySubscribers("newComment", reactionEventText);
        }

    }
}
