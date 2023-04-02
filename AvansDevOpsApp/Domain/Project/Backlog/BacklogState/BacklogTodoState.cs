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
            this._context.ChangeState(new BacklogDoingState());
        }

        public override void ChangeStateBacklogDone()
        {
            throw new InvalidOperationException();
        }

        public override void ChangeStateBacklogReadyForTesting()
        {
            throw new InvalidOperationException();
        }

        public override void ChangeStateBacklogTested()
        {
            throw new InvalidOperationException();
        }

        public override void ChangeStateBacklogTesting()
        {
            throw new InvalidOperationException();
        }

        public override void ChangeStateBacklogTodo()
        {
            throw new InvalidOperationException("Already in TODO");
        }
    }
}
