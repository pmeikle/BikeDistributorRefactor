using System.Linq;
using System.Text;

namespace BikeDistributor.Printers
{
    public class HtmlReceiptPrinter : IReceiptPrinter
    {
        public string Print(Order order)
        {
            var receipt = Receipt.ForOrder(order);
            var result = new StringBuilder($"<html><body><h1>{receipt.CompanyName}</h1>");
            if (receipt.LineItems.Any())
            {
                result.Append("<ul>");
                foreach (var line in receipt.LineItems)
                {
                    result.Append($"<li>{line}</li>");
                }
                result.Append("</ul>");
            }
            result.Append($"<h3>{receipt.SubTotal}</h3>");
            result.Append($"<h3>{receipt.Tax}</h3>");
            result.Append($"<h2>{receipt.Total}</h2>");
            result.Append("</body></html>");
            return result.ToString();
        }
    }
}
