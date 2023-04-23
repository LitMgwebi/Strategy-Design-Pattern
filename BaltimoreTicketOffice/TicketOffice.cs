using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltimoreTicketOffice
{
    class TicketOffice
    {
        private ITicketPrice ticketPrice;

        public TicketOffice() { }
        public TicketOffice(ITicketPrice ticketPrice)
        {
            this.ticketPrice = ticketPrice;
        }

        public void SetPricing(ITicketPrice tp)
        {
            this.ticketPrice = tp;
        }

        public void OutputPrice()
        {
            double salesTax = 1.2;
            double price = this.ticketPrice.CalculatePrice(salesTax);

            Console.WriteLine("Thank you for buying a ticket.");
            Console.WriteLine($"Your ticket price will cost: R{Math.Round(price, 2)}");
        }
    }
}
