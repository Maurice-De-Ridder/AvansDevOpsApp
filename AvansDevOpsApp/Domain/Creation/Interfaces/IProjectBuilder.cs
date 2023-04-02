using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Forum;
using AvansDevOpsApp.Domain.Project.Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Creation.Interfaces
{
    public interface IProjectBuilder
    {
        public void Reset();
        public void BuildProjectBacklog(IProjectBacklog projectBacklog);
        public void BuildForum();
        public void BuildProjectName(string name);
        public void BuildDescription(string description);
        public void BuildDevelopers(List<AbstractPerson> developers);
        public void BuildProjectOwner(AbstractPerson productOwner);
        public void BuildSprint(ISprint sprint);
        public AbstractProject GetProject();


    }
}
