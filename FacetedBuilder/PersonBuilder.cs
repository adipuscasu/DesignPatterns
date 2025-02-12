using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacetedBuilder
{
    public class PersonBuilder
    {
        // reference!
        protected Person person = new();
        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);
        public Person Build() => person;

        public static implicit operator Person(PersonBuilder pb) => pb.person;
    }
}
