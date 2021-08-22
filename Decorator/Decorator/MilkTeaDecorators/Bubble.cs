using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.MilkTeaDecorators
{
    public class Bubble : MilkTeaDecorator
    {
        public Bubble(IMilkTea milkTea) : base(milkTea)
        {

        }
        public override double Cost()
        {
            return 1d + base.Cost();
        }
    }
}
