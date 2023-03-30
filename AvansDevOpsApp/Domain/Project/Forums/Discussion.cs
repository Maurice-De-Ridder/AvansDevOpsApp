using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Backlog.BacklogState;
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
            Reactions = new List<Reaction>();
        }
        public void AddReaction(Reaction reaction)
        {
            // make sure the reaction can not be added when the backlogstate is done 
            if (ReferencedBacklogItem.IsCorrectState(new BacklogDoneState())) throw new Exception();
            // make the commenter subscribe to the discussion thread.
            DiscussionNotificationPublisher.Subscribe(reaction.Person);
            // add the comment
            Reactions.Add(reaction);
            // notify all other commenters
            string reactionEventText = $"{reaction.Person} added a comment to discussion {ReferencedBacklogItem.Name}.";
            DiscussionNotificationPublisher.NotifySubscribers("newMessage", reactionEventText);
        }
        
    }
}
