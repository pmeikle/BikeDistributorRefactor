using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor.Test
{
    public class TestBikeData
    {
        public static readonly Bike Defy = new Bike("Giant", "Defy 1", 1000);
        public static readonly Bike Elite = new Bike("Specialized", "Venge Elite", 2000);
        public static readonly Bike DuraAce = new Bike("Specialized", "S-Works Venge Dura-Ace", 5000);
        public static readonly IList<Discount> Discounts = new List<Discount>()
        {
            new Discount(0.9d, line => line.Bike.Price == 1000 && line.Quantity >= 20),
            new Discount(0.8d, line => line.Bike.Price == 2000 && line.Quantity >= 10),
            new Discount(0.8d, line => line.Bike.Price == 5000 && line.Quantity >= 5)
        };
    }
}
