using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Creation
{
    internal class DeveloperFactory : IPersonFactory
    {
        public AbstractPerson CreatePerson()
        {
            return new Developer();
        }
    }
}
