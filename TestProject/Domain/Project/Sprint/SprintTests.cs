using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Sprint;
using Moq;
using System;
using Xunit;

namespace TestProject.Domain.Project.Sprint
{
    public class SprintTests
    {
        private MockRepository mockRepository;
        private Mock<ISprintTypeStrategy> mockSprintTypeStrategy;

        public SprintTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Loose);

            this.mockSprintTypeStrategy = this.mockRepository.Create<ISprintTypeStrategy>();
        }

        private ConcreteSprint CreateSprint()
        {
            return new ConcreteSprint(
                "",
                DateTime.Now,
                new NotificationPublisher(),
                this.mockSprintTypeStrategy.Object);
        }

        [Fact]
        public void Subscribe_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sprint = this.CreateSprint();
            Developer person = new Developer();
            person.Name = "developer";
            // Act
            sprint.Subscribe(
                person);
       
            // Assert
            Assert.NotEmpty(sprint.Publisher.GetObservers());
            this.mockRepository.VerifyAll();
        }

        [Fact]
        public void ChangeStateCancelled_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var sprint = this.CreateSprint();

            // Act
            sprint.ChangeStateCancelled();

            // Assert
            Assert.True(false);
            this.mockRepository.VerifyAll();
        }

        //[Fact]
        //public void ChangeState_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();
        //    ISprintState sprintState = null;

        //    // Act
        //    sprint.ChangeState(
        //        sprintState);

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void SetName_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();
        //    string newName = null;

        //    // Act
        //    sprint.SetName(
        //        newName);

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void SetEndTime_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();
        //    DateTime time = default(global::System.DateTime);

        //    // Act
        //    sprint.SetEndTime(
        //        time);

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void AddBacklogItem_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();
        //    BacklogItem newItem = null;

        //    // Act
        //    sprint.AddBacklogItem(
        //        newItem);

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void RemoveBacklogItem_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();
        //    string itemName = null;

        //    // Act
        //    sprint.RemoveBacklogItem(
        //        itemName);

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void RemoveBacklogItem_StateUnderTest_ExpectedBehavior1()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();
        //    BacklogItem backlogItem = null;

        //    // Act
        //    sprint.RemoveBacklogItem(
        //        backlogItem);

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void UpdateBacklogItem_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();
        //    BacklogItem newBacklogItem = null;
        //    string backlogItemToChange = null;

        //    // Act
        //    sprint.UpdateBacklogItem(
        //        newBacklogItem,
        //        backlogItemToChange);

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void FinishSprint_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();

        //    // Act
        //    sprint.FinishSprint();

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}

        //[Fact]
        //public void CheckTime_StateUnderTest_ExpectedBehavior()
        //{
        //    // Arrange
        //    var sprint = this.CreateSprint();

        //    // Act
        //    sprint.CheckTime();

        //    // Assert
        //    Assert.True(false);
        //    this.mockRepository.VerifyAll();
        //}
    }
}
