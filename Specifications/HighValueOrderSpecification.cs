using System;

namespace SpecificationPattern.Specifications
{
    /// <summary>
    /// Order Specification for orders having order amount more than 50000 USD.
    /// </summary>
    public class HighValueOrderSpecification : Specification<Order>
    {
        public override bool IsSatisfiedBy(Order candidate)
        {
            return candidate.OrderAmount > 50000;
        }
    }
}