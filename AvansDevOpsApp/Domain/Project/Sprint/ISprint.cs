using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AvansDevOpsApp.Domain.Project.Sprint
{
    public interface ISprint
    {
        public ScrumMaster ScrumMaster;

        public void Subscribe(AbstractPerson person);
        public void ChangeStateCancelled();
    }
}
