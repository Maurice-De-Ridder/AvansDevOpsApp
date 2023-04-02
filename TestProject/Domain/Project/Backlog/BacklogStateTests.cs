using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Backlog.BacklogState;
using Domain.Domain.Person;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Test.Domain.Project.Backlog
{
    public class BacklogStateTests
    {

        [Fact]
        public void BacklogTestedStateLeadDeveloperNotTrue()
        {
            //Arrange
            var MockDeveloper = new Mock<Developer>();

            var b = new Mock<BacklogItem>();
            b.Setup(p => p.GetDeveloper()).Returns(MockDeveloper.Object);

            AbstractBacklogState TestedState = new BacklogTestedState();
            //Act
            TestedState.SetContext(b.Object);
            
            //Assert
            Assert.Throws<InvalidOperationException>(() => TestedState.ChangeStateBacklogDone());

        }

        [Fact]
        public void BacklogTestedStateBacklogActivityIsNotNullAndActivitiesAreFinished()
        {
            //Arrange
            var MockDeveloper = new Mock<LeadDeveloper>();
            var b = new Mock<BacklogItem>();
            b.Setup(p => p.GetDeveloper()).Returns(MockDeveloper.Object);
            b.Setup(p => p.GetAllActivities()).Returns(new List<BacklogActivity>{
                new BacklogActivity {IsFinished=true},
                new BacklogActivity {IsFinished=true}
            });
            AbstractBacklogState TestedState = new BacklogTestedState();
            //Act
            TestedState.SetContext(b.Object);

            //Assert
            Assert.IsType<BacklogDoneState>(TestedState);

        }
        [Fact]
        public void BacklogTestedStateBacklogActivityIsNull()
        {
            //Arrange
            var MockDeveloper = new Mock<LeadDeveloper>();
            var b = new Mock<BacklogItem>();
            b.Setup(p => p.GetDeveloper()).Returns(MockDeveloper.Object);
            AbstractBacklogState TestedState = new BacklogTestedState();
            //Act
            TestedState.SetContext(b.Object);

            //Assert
            Assert.IsType<BacklogDoneState>(TestedState);

        }

        [Fact]
        public void BacklogTestedStateBacklogActivityIsNotFinished()
        {
            //Arrange
            var MockDeveloper = new Mock<LeadDeveloper>();
            var b = new Mock<BacklogItem>();
            b.Setup(p => p.GetDeveloper()).Returns(MockDeveloper.Object);
            b.Setup(p => p.GetAllActivities()).Returns(new List<BacklogActivity>{
                new BacklogActivity {IsFinished=false},
                new BacklogActivity {IsFinished=false}
            });
            AbstractBacklogState TestedState = new BacklogTestedState();
            //Act
            TestedState.SetContext(b.Object);

            //Assert
            Assert.Throws<InvalidOperationException>(() => TestedState.ChangeStateBacklogDone());

        }

    }
}
