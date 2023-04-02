using AvansDevOpsApp.Domain.Creation.Interfaces;
using AvansDevOpsApp.Domain.Person;
using Domain.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain.Creation
{
    public class LeadDeveloperFactory : IPersonFactory
    {
        public AbstractPerson CreatePerson()
        {
            return new LeadDeveloper();
        }
    }
}
