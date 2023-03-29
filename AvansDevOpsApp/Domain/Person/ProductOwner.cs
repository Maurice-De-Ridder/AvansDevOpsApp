using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Project.Sprint.SprintState;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Person
{
    public class ProductOwner : AbstractPerson
    {
        public ProductOwner(string name, INotification notificationType) : base(name, notificationType)
        {

        }

        public override void Update(string eventType,string notification)
        {
            string x = this.NotificationType.Message(notification);

            switch (eventType)
            {
                case "Cancelled":
                    this.Inbox.Add(x);
                    break;
            }
        }

    }
}
