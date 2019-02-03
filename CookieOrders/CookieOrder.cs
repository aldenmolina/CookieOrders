using System;
using System.Collections.Generic;
using System.Text;

namespace CookieOrders
{
    class CookieOrder
    {
        public string Variety { get; set; }
        public int NumberOfBoxes { get; set; }

        public CookieOrder(string variety, int numberOfBoxes)
        {
            Variety = variety;
            NumberOfBoxes = numberOfBoxes;
        }
    }
}
