using System;

namespace SpecificationPattern.Specifications
{
    /// <summary>
    /// Domestic Order Specification
    /// </summary>
    public class DomesticOrderSpecification : Specification<Order>
    {
        public override bool IsSatisfiedBy(Order candidate)
        {
            return candidate.ShippingAddress.Country == "USA";
        }
    }
}