using AvansDevOpsApp.Domain.Notifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Person
{
    internal class ScrumMaster : AbstractPerson
    {

        public string latestMessage = "";
        public ScrumMaster(string name,INotification notificationType) :base(name,notificationType)    { }

        public override void update(string notification)
        {
            string x = this.NotificationType.message(notification);
            Console.WriteLine(x);
            latestMessage = x;
        }
    }
}
