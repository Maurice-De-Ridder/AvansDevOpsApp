using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansDevOpsApp.Domain.Person
{
    internal abstract class AbstractPerson
    {
        public string Name { get; set; }
        public AbstractPerson() { }
    }
}
