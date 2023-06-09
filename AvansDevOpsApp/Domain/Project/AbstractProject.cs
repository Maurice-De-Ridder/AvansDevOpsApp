﻿using AvansDevOpsApp.Domain.Person;
using AvansDevOpsApp.Domain.Project.Backlog;
using AvansDevOpsApp.Domain.Project.Forum;
using AvansDevOpsApp.Domain.Project.Sprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project
{
    public abstract class AbstractProject
    {
        public string Name;
        public string Description;
        public List<AbstractPerson> Developers = new List<AbstractPerson>();
        public AbstractPerson ProjectOwner;
        public List<ISprint> Sprints = new List<ISprint>();
        public IProjectBacklog ProjectBacklog;
        public IForum Forum;

    }
}
