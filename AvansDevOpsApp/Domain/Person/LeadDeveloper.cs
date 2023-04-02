using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Person
{
    public class LeadDeveloper :AbstractPerson
    {
        public LeadDeveloper() { }

        public void Update(string eventType, string notification)
        {
            base.Update(eventType, notification);
            string x = this.NotificationType.Message(notification);
            //return x;
        }

    }
}
