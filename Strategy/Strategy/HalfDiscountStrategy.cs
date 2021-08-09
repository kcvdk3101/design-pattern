using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class HalfDiscountStrategy : IPromoteStrategy
    {
        public double DoDiscount(double price)
        {
            return price * (100 - 50) / 100;
        }
    }
}
