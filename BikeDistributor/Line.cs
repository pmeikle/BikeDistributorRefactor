namespace BikeDistributor
{
    public class Line
    {
        private const double OneThousandDiscountPercentCost = .9d;
        private const double FiveThousandDiscountPercentCost = .8d;
        private const double TwoThousandDiscountPercentCost = .8d;
        private const double NoDiscountPercentCost = 1.0d;

        public Bike Bike { get; }
        public int Quantity { get; }
        private double LineCost => Quantity * Bike.Price;

        public Line(Bike bike, int quantity)
        {
            Bike = bike;
            Quantity = quantity;
        }


        public double GetLineTotalWithDiscount()
        {
            var lineCostPercent = NoDiscountPercentCost;
            switch (Bike.Price)
            {
                case Bike.OneThousand:
                    if (Quantity >= 20)
                        lineCostPercent = OneThousandDiscountPercentCost;
                    break;
                case Bike.TwoThousand:
                    if (Quantity >= 10)
                        lineCostPercent = TwoThousandDiscountPercentCost;
                    break;
                case Bike.FiveThousand:
                    if (Quantity >= 5)
                        lineCostPercent = FiveThousandDiscountPercentCost;
                    break;
            }
            return LineCost * lineCostPercent;
        }
    }
}
