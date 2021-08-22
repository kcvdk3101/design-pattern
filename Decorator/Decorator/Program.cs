using Decorator.MilkTeaDecorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new GoldBubble(new Bubble(new MilkTea()));
            var customer1 = new Bubble(new MilkTea());
            var customer2 = new WhiteBubble(new Bubble(new MilkTea()));

            Console.WriteLine(customer.Cost());
            Console.WriteLine(customer1.Cost());
            Console.WriteLine(customer2.Cost());
        }
    }
}
