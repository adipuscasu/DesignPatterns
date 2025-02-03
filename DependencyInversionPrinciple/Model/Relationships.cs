using DependencyInversionPrinciple.Enums;
using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Model
{
    internal class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relation, Person)> relations = new List<(Person, Relation, Person)>();
        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent, Relation.Parent, child));
            relations.Add((child, Relation.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            return relations.Where(
                x => x.Item1.Name == name &&
                     x.Item2 == Relation.Parent
            ).Select(r => r.Item3);
        }

        //public List<(Person, Relation, Person)> Relations => relations;
    }
}
