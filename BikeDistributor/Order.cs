using System.Collections.Generic;

namespace BikeDistributor
{
    public class Order
    {
        public readonly IList<Line> Lines = new List<Line>();
        public string Company { get; }

        public Order(string company)
        {
            Company = company;
        }

        public void AddLine(Line line)
        {
            Lines.Add(line);
        }
    }
}
