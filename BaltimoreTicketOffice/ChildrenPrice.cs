using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltimoreTicketOffice
{
    public class ChildrenPrice: ITicketPrice
    {
        public double CalculatePrice(double salesPrice)
        {
            double price = 10;

            price *= salesPrice;

            return price;
        }
    }
}
