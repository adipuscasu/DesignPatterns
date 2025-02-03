namespace OpenClosedPrinciple.Specifications
{
using OpenClosedPrinciple;
using OpenClosedPrinciple.Enums;


public class ColorSpecification : ISpecification<Product>
{
    private readonly Color color;

    public ColorSpecification(Color color)
    {
        this.color = color;
    }

    public bool IsSatisfied(Product t)
    {
        return t.Color == color;
    }
}
}