using System.Collections.Generic;
using System.Linq;

namespace BikeDistributor
{
    public class Order
    {
        public readonly IList<Line> Lines = new List<Line>();
        public readonly IList<Discount> Discounts = new List<Discount>();
        public string Company { get; }

        public Order(string company)
        {
            Company = company;
        }

        public void AddLine(Line line)
        {
            Lines.Add(line);
        }

        public void AddDiscount(Discount discount)
        {
            Discounts.Add(discount);
        }

        public void AddDiscounts(IList<Discount> discounts)
        {
            foreach (var discount in discounts)
            {
                Discounts.Add(discount);
            }
        }
    }
}
