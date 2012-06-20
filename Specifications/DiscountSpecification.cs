using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern.Specifications
{
    /// <summary>
    /// Composite Specification for Order Discount.
    /// </summary>
    public class DiscountSpecification : Specification<Order>
    {
        readonly DomesticOrderSpecification domesticOrderSpec = new DomesticOrderSpecification();
        readonly HighValueOrderSpecification highValueSpec = new HighValueOrderSpecification();
        readonly PaymentModeSpecification paymentModeSpec = new PaymentModeSpecification();
        readonly HighStockSpecification highStockSpec = new HighStockSpecification();
        readonly TaxApplicabilitySpecification taxableSpec = new TaxApplicabilitySpecification();

        /// <summary>
        /// gives whether order is eligible for discount or not.
        /// </summary>
        /// <param name="candidate">specific order</param>
        /// <returns>Whether discount is applicable or not applicable</returns>
        public override bool IsSatisfiedBy(Order candidate)
        {
            return domesticOrderSpec
                .And(highValueSpec)
                .And(highStockSpec)
                .And(taxableSpec.Not())
                .IsSatisfiedBy(candidate);
        }

    }

}
