using System.Security.Cryptography;
using BikeDistributor.Printers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeDistributor.Test
{
    [TestClass]
    public class HtmlReceiptPrintingWithDiscountsTest
    {
        [TestMethod]
        public void ReceiptTwentyDefyAppliesDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Defy, 20));
            order.AddDiscounts(TestBikeData.Discounts);
            Assert.AreEqual(HtmlResultStatementTwentyDefy, new HtmlReceiptPrinter().Print(order));
        }

        
        private const string HtmlResultStatementTwentyDefy = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>20 x Giant Defy 1 = $18,000.00</li></ul><h3>Sub-Total: $18,000.00</h3><h3>Tax: $1,305.00</h3><h2>Total: $19,305.00</h2></body></html>";


        [TestMethod]
        public void ReceiptNineteenDefyDoesntApplyDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Defy, 19));
            order.AddDiscounts(TestBikeData.Discounts);
            Assert.AreEqual(HtmlResultStatementNineteenDefy, new HtmlReceiptPrinter().Print(order));
        }

        private const string HtmlResultStatementNineteenDefy = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>19 x Giant Defy 1 = $19,000.00</li></ul><h3>Sub-Total: $19,000.00</h3><h3>Tax: $1,377.50</h3><h2>Total: $20,377.50</h2></body></html>";

        [TestMethod]
        public void ReceiptTenEliteAppliesDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Elite, 10));
            order.AddDiscounts(TestBikeData.Discounts);
            Assert.AreEqual(HtmlResultStatementTenElite, new HtmlReceiptPrinter().Print(order));
        }

        private const string HtmlResultStatementTenElite = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>10 x Specialized Venge Elite = $16,000.00</li></ul><h3>Sub-Total: $16,000.00</h3><h3>Tax: $1,160.00</h3><h2>Total: $17,160.00</h2></body></html>";

        [TestMethod]
        public void ReceiptNineEliteDoesntApplyDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Elite, 9));
            order.AddDiscounts(TestBikeData.Discounts);
            Assert.AreEqual(HtmlResultStatementNineElite, new HtmlReceiptPrinter().Print(order));
        }

        private const string HtmlResultStatementNineElite = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>9 x Specialized Venge Elite = $18,000.00</li></ul><h3>Sub-Total: $18,000.00</h3><h3>Tax: $1,305.00</h3><h2>Total: $19,305.00</h2></body></html>";

        [TestMethod]
        public void ReceiptFiveDuraAceAppliesDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.DuraAce, 5));
            order.AddDiscounts(TestBikeData.Discounts);
            Assert.AreEqual(HtmlResultStatementFiveDuraAce, new HtmlReceiptPrinter().Print(order));
        }

        private const string HtmlResultStatementFiveDuraAce = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>5 x Specialized S-Works Venge Dura-Ace = $20,000.00</li></ul><h3>Sub-Total: $20,000.00</h3><h3>Tax: $1,450.00</h3><h2>Total: $21,450.00</h2></body></html>";

        [TestMethod]
        public void ReceiptFourDuraAceDoesntApplyDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.DuraAce, 4));
            order.AddDiscounts(TestBikeData.Discounts);
            Assert.AreEqual(HtmlResultStatementFourDuraAce, new HtmlReceiptPrinter().Print(order));
        }

        private const string HtmlResultStatementFourDuraAce = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>4 x Specialized S-Works Venge Dura-Ace = $20,000.00</li></ul><h3>Sub-Total: $20,000.00</h3><h3>Tax: $1,450.00</h3><h2>Total: $21,450.00</h2></body></html>";
    }
}
