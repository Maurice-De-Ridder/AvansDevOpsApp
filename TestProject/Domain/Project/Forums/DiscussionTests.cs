using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Backlog.BacklogState;
using AvansDevOpsApp.Domain.Project.Forum;
using AvansDevOpsApp.Domain.Project.Forums;
using Moq;
using System;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using Xunit;

namespace TestProject.Domain.Project.Forums
{
    public class DiscussionTests
    {
        [Fact]
        public void AddReactionToDiscussionSucceeds()
        {
            // Arrange

            // person
            var person = new Developer();
            person.Name = "developer1";

            // notificationpublisher
            var notificationPublisher = new Mock<INotificationPublisher>();

            notificationPublisher.Setup(_ => _.NotifySubscribers("newMessage", "Added new comment"));
            notificationPublisher.Setup(_ => _.Subscribe(person));

            // backlog item
            var backlogItem = new BacklogItem();
            backlogItem.State = new BacklogDoingState();
            backlogItem.Name = "backlog";

            var discussion = new Discussion(notificationPublisher.Object);
            discussion.ReferencedBacklogItem = backlogItem;

            Reaction reaction = new Reaction();
            reaction.Text = "Test";
            reaction.Person = person;
            // Act
            discussion.AddReaction(reaction);

            // Assert
            Assert.Single(discussion.Reactions);
            Assert.Equal("Test", discussion.Reactions.First().Text);
        }

        [Fact]
        public void AddReactionToDiscussionFailsWhenStateDone()
        {
            // Arrange

            // person
            var person = new Developer();
            person.Name = "developer1";

            // notificationpublisher
            var notificationPublisher = new Mock<INotificationPublisher>();

            notificationPublisher.Setup(_ => _.NotifySubscribers("newMessage", "Added new comment"));
            notificationPublisher.Setup(_ => _.Subscribe(person));

            // backlog item
            var backlogItem = new BacklogItem();
            backlogItem.State = new BacklogDoneState();
            backlogItem.Name = "backlog";

            var discussion = new Discussion(notificationPublisher.Object);
            discussion.ReferencedBacklogItem = backlogItem;

            Reaction reaction = new Reaction();
            reaction.Text = "Test";
            reaction.Person = person;
            // Act


            // Assert
            Assert.Throws<Exception>(() => discussion.AddReaction(reaction));
            Assert.Empty(discussion.Reactions);
        }
    }
}
