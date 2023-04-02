using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog.BacklogState
{
    public class BacklogDoingState : AbstractBacklogState
    {
        public override void ChangeStateBacklogDoing()
        {
            throw new InvalidOperationException();
        }

        public override void ChangeStateBacklogDone()
        {
            throw new InvalidOperationException();
        }

        public override void ChangeStateBacklogReadyForTesting()
        {
      
            this._context.ChangeState(new BacklogReadyForTestingState());
            this._context.GetContext().GetPublisher().NotifySubscribers("ReadyForTesting", this._context.Name + " is ready for testing");
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
            throw new InvalidOperationException();
        }
    }
}
