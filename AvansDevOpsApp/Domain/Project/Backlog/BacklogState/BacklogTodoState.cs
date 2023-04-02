using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog.BacklogState
{
    public class BacklogTodoState : AbstractBacklogState
    {
        public override void ChangeStateBacklogDoing()
        {
            throw new NotImplementedException();
        }

        public override void ChangeStateBacklogDone()
        {
            throw new NotImplementedException();
        }

        public override void ChangeStateBacklogReadyForTesting()
        {
            throw new NotImplementedException();
        }

        public override void ChangeStateBacklogTested()
        {
            throw new NotImplementedException();
        }

        public override void ChangeStateBacklogTesting()
        {
            throw new NotImplementedException();
        }

        public override void ChangeStateBacklogTodo()
        {
            throw new NotImplementedException();
        }
    }
}
