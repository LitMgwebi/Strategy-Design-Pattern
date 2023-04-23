using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltimoreTicketOffice
{
    public class AdultPrice : ITicketPrice
    {
        public double CalculatePrice(double salesPrice)
        {
            double price = 15;
            price *= salesPrice;
            return price;
        }
    }
}
