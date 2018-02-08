using System;
using System.Text;

namespace BikeDistributor.Printers
{
    public class TextReceiptPrinter : IReceiptPrinter
    {
        public string Print(Order order)
        {
            var receipt = Receipt.ForOrder(order);
            var result = new StringBuilder($"{receipt.CompanyName}{Environment.NewLine}");
            foreach (var lineItem in receipt.LineItems)
            {
                result.AppendLine($"\t{lineItem}");
            }
            result.AppendLine($"{receipt.SubTotal}");
            result.AppendLine($"{receipt.Tax}");
            result.Append($"{receipt.Total}");
            return result.ToString();
        }
    }
}
