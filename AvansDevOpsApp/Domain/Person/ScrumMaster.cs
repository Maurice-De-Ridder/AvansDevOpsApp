using AvansDevOpsApp.Domain.Notifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Person
{
    public class ScrumMaster : AbstractPerson
    {

        public ScrumMaster()    { }

        public void Update(string eventType, string notification)
        {
            base.Update(eventType, notification);  

            string x = this.NotificationType.Message(notification);
            
            switch(eventType)
            {
                case "Cancelled":
                    this.Inbox.Add(x);
                    break;

                case "ItemSwitch":
                    this.Inbox.Add(x);
                    break;
            }
           
        }
    }
}
