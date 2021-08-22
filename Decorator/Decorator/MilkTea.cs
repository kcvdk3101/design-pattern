using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class MilkTea : IMilkTea
    {
        public double Cost()
        {
            return 5d;
        }
    }
}
