using System.Linq;

namespace SpecificationPattern.Specifications
{
    /// <summary>
    /// High Stock value specification
    /// </summary>
    public class HighStockSpecification : Specification<Order>
    {
        public override bool IsSatisfiedBy(Order candidate)
        {
            return (candidate.SKUs > 1000);
        }
    }
}