﻿using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog.BacklogState;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public string DoD;
        public AbstractBacklogState State;

        public AbstractPerson? Developer;
        private List<BacklogActivity>? Activities;

        private IEnumerableBacklog _context;

        public BacklogItem() 
        {
            this.ChangeState(new BacklogTodoState());
        }

        public Boolean IsCorrectState(AbstractBacklogState expectedState)
        {
            return expectedState.GetType() == State.GetType();
        }

        public void ChangeContext(IEnumerableBacklog context)
        {
            this._context = context;
        }

        public IEnumerableBacklog GetContext()
        {
            return this._context;
        }

        public void ChangeState(AbstractBacklogState State)
        {
            this.State = State;
            this.State.SetContext(this);
        }

        public void ChangeStateBacklogDoing()
        {
            this.State.ChangeStateBacklogDoing();
        }

        public void ChangeStateBacklogDone()
        {
            this.State.ChangeStateBacklogDone();
        }

        public void ChangeStateBacklogReadyForTesting()
        {
            this.State.ChangeStateBacklogReadyForTesting();
           
        }

        public void ChangeStateBacklogTested()
        {
            this.State.ChangeStateBacklogTested();
        }

        public void ChangeStateBacklogTesting()
        {
            this.State.ChangeStateBacklogTesting();
        }

        public void ChangeStateBacklogTodo()
        {
            this.State.ChangeStateBacklogTodo();
        }

        public void AddDeveloper(AbstractPerson developer)
        {
            if (Activities != null || this.Developer == null)
            {
                this.Developer = developer;
                this._context.GetPublisher().NotifySubscribers("ItemSwitch", developer.Name + " Got assigned " + this.Name);
            }
            else
            {
                throw new ArgumentException("Activities is either not null or developer already assigned");
            }
        }
        public void RemoveDeveloper()
        {
            this.Developer = null;
        }
        public virtual AbstractPerson GetDeveloper()
        {
            if (this.Developer != null)
            {
                return this.Developer;
            }
            else
            {
                throw new ArgumentException("Developer is empty");
            }
           
        }

        public void InitActivity()
        {
            if (Developer == null || this.Activities == null)
            {
                this.Activities = new List<BacklogActivity>();
                Console.Write("Test");
            }
            else
            {
                throw new ArgumentException("Developer needs to be empty to init activity or list is already initialized");
            }
        }
        public void AddActivity(BacklogActivity activity)
        {
            if(this.Activities != null)
            {
                this.Activities.Add(activity);
            }
            else
            {
                throw new ArgumentException("Activities is not initialized");
            }
        }
        public void RemoveActivity(BacklogActivity activity)
        {
            if (this.Activities != null)
            {
                this.Activities.Remove(activity);
            }
            else
            {
                throw new ArgumentException("Activities is not initialized");
            }
            
        }
        public virtual List<BacklogActivity> GetAllActivities()
        {
            return this.Activities;

        }
    }
}
