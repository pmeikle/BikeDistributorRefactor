namespace BikeDistributor.Printers
{
    public interface IReceiptPrinter
    {
        string Print(Order order);
    }
}
