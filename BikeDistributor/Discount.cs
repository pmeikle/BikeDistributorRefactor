using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor
{
    public class Discount
    {
        public Discount(double discountPercentage, Func<Line, bool> doesDiscountApply)
        {
            DiscountPercentage = discountPercentage;
            DoesDiscountApply = doesDiscountApply;
        }

        public double DiscountPercentage { get; set; }

        public Func<Line, bool> DoesDiscountApply { get; set; }
    }
}
