namespace BikeDistributor
{
    public class Line
    {

        public Bike Bike { get; }
        public int Quantity { get; }
        public double LineCost => Quantity * Bike.Price;

        public Line(Bike bike, int quantity)
        {
            Bike = bike;
            Quantity = quantity;
        }
    }
}
