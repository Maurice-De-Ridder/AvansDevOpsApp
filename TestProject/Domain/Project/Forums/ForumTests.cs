using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Forum;
using AvansDevOpsApp.Domain.Project.Forums;
using System;
using Xunit;

namespace TestProject.Domain.Project.Forums
{
    public class ForumTests
    {
        [Fact]
        public void AddDiscussion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var forum = new Forum();
            BacklogItem backlogItem = new BacklogItem();
            NotificationPublisher notificationPublisher = new NotificationPublisher();
            AbstractPerson person = new Developer();
            // Act
            forum.AddDiscussion(
                backlogItem, notificationPublisher, person);
            // Assert
            Assert.True(false);
        }

        [Fact]
        public void RemoveDiscussion_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var forum = new Forum();
            BacklogItem backlogItem = null;

            // Act
            forum.RemoveDiscussion(
                backlogItem);

            // Assert
            Assert.True(false);
        }
    }
}
