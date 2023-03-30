using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project;
using AvansDevOpsApp.Domain.Project.Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Creation
{
    public class ProjectBuildingDirector 
    {
        private IProjectBuilder _builder;
        public ProjectBuildingDirector(IProjectBuilder builder) 
        {
            _builder = builder;
        }

        public AbstractProject BuildProjectFull(string name, string description, List<AbstractPerson> developers, AbstractPerson productOwner,ISprint sprint)
        {
            this._builder.BuildProjectBacklog();
            this._builder.BuildForum();
            this._builder.BuildProjectName(name);
            this._builder.BuildDescription(description);
            this._builder.BuildDevelopers(developers);
            this._builder.BuildProjectOwner(productOwner);
            this._builder.BuildSprint(sprint);
            this._builder.BuildProjectBacklog();
            return this._builder.GetProject();
        }


    }
}
