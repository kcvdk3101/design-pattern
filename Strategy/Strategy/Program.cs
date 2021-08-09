using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            Console.Write("Enter number of tickets: ");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var ticket = new Ticket();
                ticket.Id = generateID();
                ticket.Name = "Name" + " " + i;
                ticket.Price = 50 * i;
                GenerateRandomStrategy(random, ticket);
                LogTicketDetail(ticket);
            }

            Console.ReadKey();
        }

        private static void LogTicketDetail(Ticket ticket)
        {
            Console.WriteLine("Ticket Details" + "\n" +
                                "--------------" + "\n" +
                                "Ticket Id: " + ticket.Id + "\n" +
                                "Ticket Name: " + ticket.Name + "\n" + "Price: " + ticket.Price + "\n" +
                                "Promoted Price: " + ticket.GetPromotedPrice() + "\n" +
                                "Type of Discount Strategy: " + ticket.PromoteStrategy.GetType().Name);
            Console.WriteLine("---------------------------");
            Console.WriteLine();
        }

        private static void GenerateRandomStrategy(Random random, Ticket ticket)
        {
            var strategyIndex = random.Next(0, 4);
            switch (strategyIndex)
            {
                case 0:
                    ticket.PromoteStrategy = new QuarterDiscountStrategy();
                    break;
                case 1:
                    ticket.PromoteStrategy = new ThirtyDiscountStrategy();
                    break;
                case 2:
                    ticket.PromoteStrategy = new HalfDiscountStrategy();
                    break;
                default:
                    ticket.PromoteStrategy = new NoDiscountStrategy();
                    break;
            }
        }

        private static string generateID()
        {
            return Guid.NewGuid().ToString("N");
        }



    }
}
