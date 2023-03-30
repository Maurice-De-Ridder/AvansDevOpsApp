using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project.Forums
{
    public class Reaction
    {
        public AbstractPerson Person { get; set; }
        public string Text { get; set; } 
        public DateTime CommentDate { get; set; }
        public Reaction() { }
    }
}
