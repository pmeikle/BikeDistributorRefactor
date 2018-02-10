using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor
{
    public static class DiscountCalculator
    {
        public static double CalculateDiscountedLineCost(IList<Discount> discounts, Line line)
        {
            var biggestApplicableDiscount = discounts.OrderBy(d => d.DiscountPercentage).FirstOrDefault(d => d.DoesDiscountApply(line))?.DiscountPercentage ??
                                            1.0d;
            return biggestApplicableDiscount * line.LineCost;
        }
    }
}
