using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MilkTeaDecorators
{
    public class GoldBubble : MilkTeaDecorator
    {
        public GoldBubble(IMilkTea milkTea) : base(milkTea)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}
