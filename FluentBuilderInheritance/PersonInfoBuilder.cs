using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderInheritance
{
    public class PersonInfoBuilder
    {
        protected Person person = new();
        public PersonInfoBuilder Called(string name)
        {
            person.Name = name;
            return this;
        }
    }
}
