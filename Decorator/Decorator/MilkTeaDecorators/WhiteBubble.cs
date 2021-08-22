using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MilkTeaDecorators
{
    public class WhiteBubble : MilkTeaDecorator
    {
        public WhiteBubble(IMilkTea milkTea) : base(milkTea)
        {
        }
        public override double Cost()
        {
            return 2d + base.Cost();
        }
    }
}
