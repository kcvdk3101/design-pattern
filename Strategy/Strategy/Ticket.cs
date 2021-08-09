using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Ticket
    {
        private string _id;
        private string _name;
        private double _price;
        private IPromoteStrategy _promoteStrategy;

        public Ticket() { }
        public Ticket(IPromoteStrategy promoteStrategy) {
        }

        public double GetPromotedPrice()
        {
            return _promoteStrategy.DoDiscount(_price);
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public IPromoteStrategy PromoteStrategy { get => _promoteStrategy; set => _promoteStrategy = value; }
    }
}
