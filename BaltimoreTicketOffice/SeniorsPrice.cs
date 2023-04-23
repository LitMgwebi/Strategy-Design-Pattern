using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltimoreTicketOffice
{
    public class SeniorsPrice: ITicketPrice
    {
        public double CalculatePrice(double salesPrice)
        {
            double price = 12;
            price *= salesPrice;
            return price;
        }
    }
}
