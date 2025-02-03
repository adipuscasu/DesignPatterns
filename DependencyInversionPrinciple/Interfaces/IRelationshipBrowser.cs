using DependencyInversionPrinciple.Model;

namespace DependencyInversionPrinciple.Interfaces
{
    internal interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
