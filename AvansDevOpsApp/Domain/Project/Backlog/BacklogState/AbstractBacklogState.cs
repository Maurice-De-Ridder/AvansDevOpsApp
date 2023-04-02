using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog.BacklogState
{
    public abstract class AbstractBacklogState 
    {
        protected BacklogItem _context;

        public void SetContext(BacklogItem context)
        {
            this._context= context;
        }

        public abstract void ChangeStateBacklogTodo();
        public abstract void ChangeStateBacklogDoing();
        public abstract void ChangeStateBacklogReadyForTesting();
        public abstract void ChangeStateBacklogTesting();
        public abstract void ChangeStateBacklogTested();
        public abstract void ChangeStateBacklogDone();

    }
}
