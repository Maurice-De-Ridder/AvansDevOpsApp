using AvansDevOpsApp.Domain.Person;
using Domain.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Backlog.BacklogState
{
    public class BacklogTestedState : AbstractBacklogState
    {
        public override void ChangeStateBacklogDoing()
        {
            throw new InvalidOperationException();
        }

        public override void ChangeStateBacklogDone()
        {
            if(this._context.GetDeveloper().GetType() == typeof(LeadDeveloper)){
                this._context.ChangeState(new BacklogDoneState());
            }
            else
            {
                throw new InvalidOperationException("Only lead developers are allowed to set done");
            }
        }

        public override void ChangeStateBacklogReadyForTesting()
        {
            if (this._context.GetDeveloper().GetType() == typeof(LeadDeveloper))
            {
                this._context.ChangeState(new BacklogReadyForTestingState());
            }
            else
            {
                throw new InvalidOperationException("Only lead developers are allowed to set back to ready for testing");
            }
            
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
