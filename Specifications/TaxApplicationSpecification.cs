using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern.Specifications
{
    /// <summary>
    /// Tax Applicability Specification
    /// </summary>
    public class TaxApplicabilitySpecification : Specification<Order>
    {
        public override bool IsSatisfiedBy(Order candidate)
        {
            return candidate.IsTaxApplicable;
        }
    }
}
