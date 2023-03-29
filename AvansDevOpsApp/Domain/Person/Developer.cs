using AvansDevOpsApp.Domain.Notifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Person
{
    public class Developer : AbstractPerson
    {

        public Developer()
        {
        }

        public override void Update(string eventType ,string notification)
        {
            string x = this.NotificationType.Message(notification);
            //return x;
        }
    }
}
