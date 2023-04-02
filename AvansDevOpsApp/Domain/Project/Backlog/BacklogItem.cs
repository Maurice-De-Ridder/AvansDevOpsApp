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
        public IBacklogState State;

        private AbstractPerson? Developer;
        private List<BacklogActivity>? Activities;

        public BacklogItem() { }

        public Boolean IsCorrectState(IBacklogState expectedState)
        {
            return expectedState.GetType() == State.GetType();
        }


        public void AddDeveloper(AbstractPerson developer)
        {
            if (Activities != null || this.Developer == null)
            {
                this.Developer = developer;
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
        public AbstractPerson GetDeveloper()
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
        public List<BacklogActivity> GetAllActivities()
        {
            if (this.Activities != null)
            {
                return this.Activities;
            }
            else
            {
                throw new ArgumentException("Activity is empty cannot get activities");
            }
        }
        public void ChangeState(IBacklogState newState)
        {
            this.State = newState;
        }
        public void ChangeStateTesting()
        {
            this.ChangeState(new BacklogTestingState());
        }
        public void ChangeStateReadyForTesting()
        {
            this.ChangeState(new BacklogReadyForTestingState());
        }
    }
}
