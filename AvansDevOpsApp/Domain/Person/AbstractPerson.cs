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

        public INotification NotificationType;

        public AbstractPerson(string name, INotification notificationType) 
        { 
            this.Name = name;
            this.NotificationType = notificationType; 
        }

        public abstract void update(string notification);
       
    
    }
}
