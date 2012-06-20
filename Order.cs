using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpecificationPattern.Specifications;

namespace SpecificationPattern
{
    /// <summary>
    /// Order Business Entity
    /// </summary>
    public class Order
    {
        public PaymentMode ModeOfPayment { get; set; }
        public virtual Address ShippingAddress { get; set; }
        public int SKUs { get; set; }
        public int Discount;
        public bool AllowDiscount;
        public decimal OrderAmount { get; set; }
        public bool IsTaxApplicable { get; set; }

        /// <summary>
        /// Checks the order for whether discount is applicable or not for this order. 
        /// This method is written for explanation purpose. This method is example of how, business rules are lost inside the application 
        /// with  if-else constructs and also repeated all across application.
        /// </summary>
        /// <returns>success,if discount is applicable for this order otherwise,false.</returns>
        public bool HasDiscountWithoutSpecification()
        {
            if (SKUs >= 10000 && ModeOfPayment == PaymentMode.CashOnDelivery && ShippingAddress.Country == "USA" && OrderAmount >= 50000 && IsTaxApplicable == false)
            {
                AllowDiscount = true;
            }

            return AllowDiscount;
        }

        /// <summary>
        /// Checks the order for whether discount is applicable or not for this order. 
        /// This method demonstrates how specification pattern is used inside actual code.
        /// Compare implementation of this method with that of "HasDiscountWithoutSpecifiaction".
        /// Using Specification pattern, business rules are concentrated at one place and it is easy to manage them.
        /// </summary>
        /// <returns>success,if discount is applicable for this order otherwise,false.</returns>
        public bool HasDiscountWithSpecification()
        {
            var spec = new DiscountSpecification();
            return spec.IsSatisfiedBy(this);
        }




    }
}
