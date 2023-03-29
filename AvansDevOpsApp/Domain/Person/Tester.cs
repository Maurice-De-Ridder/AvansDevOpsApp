using AvansDevOpsApp.Domain.Notifier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Person
{
    internal class Tester : AbstractPerson
    {
        public Tester(string name, INotification notificationType) : base(name, notificationType)
        {

        }

        public override void update(string notification)
        {
            throw new NotImplementedException();
        }
    }
}
