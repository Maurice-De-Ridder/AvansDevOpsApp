using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog.BacklogState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog
{
    public class BacklogItem
    {

        public string Name;
        public string Description;
        public int StoryPoints;
        public AbstractPerson? Developer;
        public List<BacklogActivity>? Activities = new List<BacklogActivity>();
        public string DoD;
        public IBacklogState State;


        public BacklogItem() { }

        public Boolean IsCorrectState(IBacklogState expectedState)
        {
            return expectedState.GetType() == State.GetType();
        }

    }
}
