using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog.BacklogState
{
    public class BacklogTestingState : AbstractBacklogState
    {
        public override void ChangeStateBacklogDoing()
        {
            throw new InvalidOperationException("Not allowed to go back to doing from Testing");
        }

        public override void ChangeStateBacklogDone()
        {
            throw new InvalidOperationException("Not allowed to go to done needs to be checked by lead developer");
        }

        public override void ChangeStateBacklogReadyForTesting()
        {
            throw new NotImplementedException();
        }

        public override void ChangeStateBacklogTested()
        {
            this._context.ChangeState(new BacklogTestedState());
        }

        public override void ChangeStateBacklogTesting()
        {
            throw new InvalidOperationException("Already in Testing");
        }

        public override void ChangeStateBacklogTodo()
        {
            this._context.ChangeState(new BacklogTodoState());
        }
    }
}
