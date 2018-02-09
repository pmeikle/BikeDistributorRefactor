using BikeDistributor.Printers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeDistributor.Test
{
    [TestClass]
    public class TextReceiptPrintingWithDiscountsTest
    {
        [TestMethod]
        public void ReceiptTwentyDefyAppliesDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Defy, 20));
            Assert.AreEqual(ResultStatementTwentyDefy, new TextReceiptPrinter().Print(order));
        }

        private const string ResultStatementTwentyDefy = @"Order Receipt for Anywhere Bike Shop
	20 x Giant Defy 1 = $18,000.00
Sub-Total: $18,000.00
Tax: $1,305.00
Total: $19,305.00";

        [TestMethod]
        public void ReceiptNineteenDefyDoesntApplyDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Defy, 19));
            Assert.AreEqual(ResultStatementNineteenDefy, new TextReceiptPrinter().Print(order));
        }

        private const string ResultStatementNineteenDefy = @"Order Receipt for Anywhere Bike Shop
	19 x Giant Defy 1 = $19,000.00
Sub-Total: $19,000.00
Tax: $1,377.50
Total: $20,377.50";

        [TestMethod]
        public void ReceiptTenEliteAppliesDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Elite, 10));
            Assert.AreEqual(ResultStatementTenElite, new TextReceiptPrinter().Print(order));
        }

        private const string ResultStatementTenElite = @"Order Receipt for Anywhere Bike Shop
	10 x Specialized Venge Elite = $16,000.00
Sub-Total: $16,000.00
Tax: $1,160.00
Total: $17,160.00";

        [TestMethod]
        public void ReceiptNineEliteDoesntApplyDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.Elite, 9));
            Assert.AreEqual(ResultStatementNineElite, new TextReceiptPrinter().Print(order));
        }

        private const string ResultStatementNineElite = @"Order Receipt for Anywhere Bike Shop
	9 x Specialized Venge Elite = $18,000.00
Sub-Total: $18,000.00
Tax: $1,305.00
Total: $19,305.00";

        [TestMethod]
        public void ReceiptFiveDuraAceAppliesDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.DuraAce, 5));
            Assert.AreEqual(ResultStatementFiveDuraAce, new TextReceiptPrinter().Print(order));
        }

        private const string ResultStatementFiveDuraAce = @"Order Receipt for Anywhere Bike Shop
	5 x Specialized S-Works Venge Dura-Ace = $20,000.00
Sub-Total: $20,000.00
Tax: $1,450.00
Total: $21,450.00";

        [TestMethod]
        public void ReceiptFourDuraAceDoesntApplyDiscount()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(TestBikeData.DuraAce, 4));
            Assert.AreEqual(ResultStatementFourDuraAce, new TextReceiptPrinter().Print(order));
        }

        private const string ResultStatementFourDuraAce = @"Order Receipt for Anywhere Bike Shop
	4 x Specialized S-Works Venge Dura-Ace = $20,000.00
Sub-Total: $20,000.00
Tax: $1,450.00
Total: $21,450.00";
    }
}
