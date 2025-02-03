namespace OpenClosedPrinciple.Specifications
{
    public class AndSpecification<T> : ISpecification<Product>
    {
        private readonly ColorSpecification colorSpecification;
        private readonly SizeSpecification sizeSpecification;

        public AndSpecification(ColorSpecification colorSpecification, SizeSpecification sizeSpecification)
        {
            this.colorSpecification = colorSpecification;
            this.sizeSpecification = sizeSpecification;
        }
        public bool IsSatisfied(Product t)
        {
            return colorSpecification.IsSatisfied(t) && sizeSpecification.IsSatisfied(t);
        }
    }
}
