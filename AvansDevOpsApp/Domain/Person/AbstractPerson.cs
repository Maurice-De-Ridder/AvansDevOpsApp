using AvansDevOpsApp.Domain.Notifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Person
{
    public abstract class AbstractPerson
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public INotification NotificationType;

        public List<string> Inbox = new List<string>();

        public AbstractPerson() 
        { 

        }

        public abstract void Update(string eventType ,string notification);
       
    
    }
}
