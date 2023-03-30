using AvansDevOpsApp.Domain.Creation;
using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project;
using AvansDevOpsApp.Domain.Project.Sprint;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class FN01
    {

        [Fact]
        public void FN01_Project_aanmaken()
        {
            //Arrange
            var ProductOwner = Mock.Of<ProductOwner>();
            string ProjectName = "test";
            string Description = "VoorDeTest";
            var Developers = Mock.Of<List<AbstractPerson>>();
            var Sprint = Mock.Of<ISprint>();

            //Act
            IProjectBuilder ProjectBuilder = new GithubProjectBuilder();
            ProjectBuildingDirector Director = new ProjectBuildingDirector(ProjectBuilder);
            AbstractProject TestProject = Director.BuildProjectFull(ProjectName, Description, Developers, ProductOwner, Sprint);

            //Assert
            Assert.NotNull(TestProject);
            Assert.Equal(ProjectName, TestProject.Name);
            Assert.Equal(Description, TestProject.Description);

        }
    }
}
