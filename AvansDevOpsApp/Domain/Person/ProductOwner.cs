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
        public ProductOwner() : base()
        {

        }

        public void Update(string eventType,string notification)
        {
            base.Update(eventType, notification);
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
