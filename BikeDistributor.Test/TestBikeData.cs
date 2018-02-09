﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDistributor.Test
{
    public class TestBikeData
    {
        public static readonly Bike Defy = new Bike("Giant", "Defy 1", Bike.OneThousand);
        public static readonly Bike Elite = new Bike("Specialized", "Venge Elite", Bike.TwoThousand);
        public static readonly Bike DuraAce = new Bike("Specialized", "S-Works Venge Dura-Ace", Bike.FiveThousand);
    }
}
