using System.Collections.Generic;
using System.Linq;

namespace BikeDistributor
{
    public class Receipt
    {
        private const double TaxRate = .0725d;
        public string CompanyName { get; set; }
        public List<string> LineItems { get; set; }
        public string SubTotal { get; set; }
        public string Tax { get; set; }
        public string Total { get; set; }

        public static Receipt ForOrder(Order order)
        {
            var subTotal = order.Lines.ToList().Sum(line => line.GetLineTotalWithDiscount());
            var taxes = subTotal * TaxRate;
            return new Receipt()
            {
                CompanyName = $"Order Receipt for {order.Company}",
                LineItems = order.Lines.ToList().Select(line => $"{line.Quantity} x {line.Bike.Brand} {line.Bike.Model} = {line.GetLineTotalWithDiscount():C}").ToList(),
                SubTotal = $"Sub-Total: {subTotal:C}",
                Tax = $"Tax: {taxes:C}",
                Total = $"Total: {subTotal + taxes:C}"
            };
        }
    }
}
