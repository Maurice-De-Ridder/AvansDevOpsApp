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
            BacklogItem backlogItem = null;

            // Act
            forum.AddDiscussion(
                backlogItem);

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
