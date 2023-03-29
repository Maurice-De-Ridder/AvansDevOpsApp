using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Forum;
using AvansDevOpsApp.Domain.Project.Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Creation
{
    public class GithubProjectBuilder : IProjectBuilder
    {
        private GithubProject Project;

        public GithubProjectBuilder() 
        {
            this.Reset();
        }

        public void Reset()
        {
            this.Project = new GithubProject();
        }
        public void BuildProjectBacklog()
        {
            this.Project.ProjectBacklog = new ProjectBacklog();
        }
        public void BuildForum()
        {
            this.Project.Forum = new Forum();
        }

        public void BuildProjectName(string name)
        {
            this.Project.Name = name;
        }

        public void BuildDescription(string description)
        {
            this.Project.Description = description;
        }

        public void BuildDevelopers(List<AbstractPerson> developers)
        {
            this.Project.Developers = developers;
        }

        public void BuildProjectOwner(AbstractPerson productOwner)
        {
            this.Project.ProjectOwner = productOwner;
        }

        public void BuildSprint(ISprint sprint)
        {
            this.Project.Sprints.Add(sprint);
        }
        public IProject GetProject()
        {
            var p = this.Project;
            this.Reset();
            return p;
        }



    }
}
