using AvansDevOpsApp.Domain.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Creation.Interfaces
{
    public interface IPersonFactory
    {
        public AbstractPerson CreatePerson();
    }
}
