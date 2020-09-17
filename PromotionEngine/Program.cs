using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number of Items in the Cart");
            int x = Convert.ToInt32(Console.ReadLine());

            List<CartModel> items = new List<CartModel>();
                       
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("enter any one of these items to add to cart A or B or C or D");
                string type = Console.ReadLine();
                CartModel p = new CartModel(type);
                items.Add(p);
            }

            int totalPrice = GetCheckoutPrice(items);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        private static int GetCheckoutPrice(List<CartModel> items)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (CartModel pr in items)
            {
                if (pr.Unit == "A" || pr.Unit == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Unit == "B" || pr.Unit == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Unit == "C" || pr.Unit == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Unit == "D" || pr.Unit == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
