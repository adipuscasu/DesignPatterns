namespace OpenClosedPrinciple.Filters
{
    using System.Collections.Generic;
    using OpenClosedPrinciple.Enums;
    using OpenClosedPrinciple.Specifications;

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var i in items)
            {
                if (spec.IsSatisfied(i))
                {
                    yield return i;
                }
            }
        }
    }
}