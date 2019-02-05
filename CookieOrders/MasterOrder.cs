using System;
using System.Collections.Generic;
using System.Text;

namespace CookieOrders
{
    class MasterOrder
    {
        public List<CookieOrder> orders { get; set; }

        public void AddOrder(CookieOrder theOrder)
        {
            orders.Add(theOrder);
        }

        public int GetTotalBoxes()
        {
            int totalBoxes = 0;
            foreach (CookieOrder box in orders)
            {
                totalBoxes += box.NumberOfBoxes;
            }
            return totalBoxes;
        }

        public void RemoveVariety(string variety)
        {
            foreach (CookieOrder box in orders)
            {
                if (box.Variety == variety)
                {
                    orders.Remove(boxrc);
                }
            }
        }

        public int GetVarietyBoxes(string variety)
        {
            int totalBoxesOfVariety = 0;
            foreach (CookieOrder box in orders)
            {
                if (box.Variety == variety)
                {
                    totalBoxesOfVariety += box.NumberOfBoxes;
                }
            }
            return totalBoxesOfVariety;
        }

        public void ShowOrder()
        {
            int orderNumber = 0;
            foreach (CookieOrder box in orders)
            {
                Console.WriteLine("Order Number " + (orderNumber + 1) + " Variety: " + box.Variety + " Number of Boxes Ordered: " + box.NumberOfBoxes);
            }
        }
    }

    

}
