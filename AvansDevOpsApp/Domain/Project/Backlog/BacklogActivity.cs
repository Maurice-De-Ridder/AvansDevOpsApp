using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog.BacklogState;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog
{
    public class BacklogActivity
    {

        public string Name;
        public string Description;
        public int StoryPoints;
        public AbstractPerson Developer;
        public string DoD;
        public bool IsFinished = false;

        public BacklogActivity()
        {

        }
    }
}
