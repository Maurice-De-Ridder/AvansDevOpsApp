using AvansDevOpsApp.Domain.Project.Backlog;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class FN03
    {

        [Fact]
        public void FN03_Backlog_Activities()
        {
            //Arrange
            var ActivityOne = Mock.Of<BacklogActivity>();
            var ActivityTwo = Mock.Of<BacklogActivity>();
            var ActivityThree = Mock.Of<BacklogActivity>();

            BacklogItem BacklogItem = new BacklogItem();

            //Act
            BacklogItem.InitActivity();
            BacklogItem.AddActivity(ActivityOne);
            BacklogItem.AddActivity(ActivityTwo);
            BacklogItem.AddActivity(ActivityThree);

            List<BacklogActivity> Activities = BacklogItem.GetAllActivities();

            //Assert
            Assert.True(Activities.Count == 3);
            Assert.Equal(Activities[0],ActivityOne);
            Assert.Equal(Activities[1], ActivityTwo);
            Assert.Equal(Activities[2], ActivityThree);
        }
    }
}
