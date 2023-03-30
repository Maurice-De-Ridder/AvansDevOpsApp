using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Notifier;
using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Creation
{
    public class DeveloperFactory : IPersonFactory
    {
        public AbstractPerson CreatePerson()
        {
            //TODO Change this to something logical
            return new Developer();
        }
    }
}
