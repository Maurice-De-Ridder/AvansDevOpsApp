using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Creation;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Sprint;
using AvansDevOpsApp.Domain.Project;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Backlog.BacklogState;

namespace TestProject
{
    public class FN02
    {

        [Fact]
        public void FN02_Backlog_Ordered_list_of_backlog()
        {
            //Arrange
            var ItemOne =  Mock.Of<BacklogItem>();
            var ItemTwo = Mock.Of<BacklogItem>();
            var ItemThree = Mock.Of<BacklogItem>();

            ProjectBacklog Backlog = new ProjectBacklog();
            
            //Act
            Backlog.Add(ItemOne);
            Backlog.Add(ItemTwo);
            Backlog.Add(ItemThree);
            List<BacklogItem> TestBacklogItem = Backlog.GetItems();
                
            //Assert
            Assert.Equal(TestBacklogItem[0],ItemOne);
            Assert.Equal(TestBacklogItem[1],ItemTwo);
            Assert.Equal(TestBacklogItem[2],ItemThree);
        }

        [Fact]
        public void FN02_BacklogItem()
        {
            //Arrange
            var DeveloperEen = Mock.Of<AbstractPerson>();
            string Name = "Item";
            string Description = "Description";
            int StoryPoints = 1;
            string DoD = "Now";
            IBacklogState State = Mock.Of<IBacklogState>();

            BacklogItem item = new BacklogItem();

            //Act
            item.Name = Name;
            item.Description = Description;
            item.StoryPoints = StoryPoints;
            item.DoD = DoD;
            item.Developer = DeveloperEen;
            item.State = State;


            //Assert
            Assert.Equal(item.Name, Name);
            Assert.Equal(item.Description, Description);
            Assert.Equal(item.StoryPoints, StoryPoints);
            Assert.Equal(item.DoD, DoD);
            Assert.Equal(item.Developer, DeveloperEen);
            Assert.Equal(item.State, State);
        }
    }
}
