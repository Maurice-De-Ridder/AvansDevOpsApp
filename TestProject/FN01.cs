using AvansDevOpsApp.Domain.Creation;
using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project;
using AvansDevOpsApp.Domain.Project.Sprint;
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
            IPersonFactory DeveloperFactory = new DeveloperFactory();
            IPersonFactory ProductOwnerFactory = new ProductOwnerFactory();
            IPersonFactory ScrumMasterFactory = new ScrumMasterFactory();
            
            AbstractPerson DeveloperEen = DeveloperFactory.CreatePerson();
            AbstractPerson DeveloperTwee = DeveloperFactory.CreatePerson();
           
            AbstractPerson ScrumMasterEen = ScrumMasterFactory.CreatePerson();
            AbstractPerson ProductOwner = ProductOwnerFactory.CreatePerson();

            string ProjectName = "test";
            string Description = "VoorDeTest";
            List<AbstractPerson> Developers = new List<AbstractPerson>{
                DeveloperEen,
                DeveloperTwee,
                ScrumMasterEen,
            };

            ISprint Sprint = new Sprint("init",new NotificationPublisher());

            IProjectBuilder ProjectBuilder = new GithubProjectBuilder();
            ProjectBuildingDirector Director = new ProjectBuildingDirector(ProjectBuilder);

            AbstractProject TestProject = Director.BuildProjectFull(ProjectName,Description,Developers,ProductOwner,Sprint);
            Assert.NotNull(TestProject);
            Assert.Equal(ProjectName, TestProject.Name);
            Assert.Equal(Description, TestProject.Description);
            Assert.Equal(Developers,TestProject.Developers);
            Assert.Equal(Sprint, TestProject.Sprints[0]);
            

        }
    }
}
