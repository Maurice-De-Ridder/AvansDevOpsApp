using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Project
{
    public interface IEnumerableBacklog
    {

        public void Subscribe(AbstractPerson p);

        public INotificationPublisher GetPublisher();
    }
}
