using System.Linq;

namespace SpecificationPattern.Specifications
{
    /// <summary>
    /// Payment Mode Specification
    /// </summary>
    public class PaymentModeSpecification : Specification<Order>
    {
        public override bool IsSatisfiedBy(Order candidate)
        {
            return (candidate.ModeOfPayment == PaymentMode.CashOnDelivery);
        }
    }
}