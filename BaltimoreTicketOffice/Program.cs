using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltimoreTicketOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketOffice office = new TicketOffice();

            Console.Write("Hello, Welcome to the Baltimore Orioles Stadium Ticket Office.\n\nHow old are you: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (age < 16)
            {
                office.SetPricing(new ChildrenPrice());
                office.OutputPrice();
            }
            else if (age >= 65)
            {
                office.SetPricing(new SeniorsPrice());
                office.OutputPrice();
            }
            else
            {
                office.SetPricing(new AdultPrice());
                office.OutputPrice();
            }
        }
    }
}
