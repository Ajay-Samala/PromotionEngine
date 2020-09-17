using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the Number of Items in the Cart");
            int x = Convert.ToInt32(Console.ReadLine());

            List<CartModel> items = new List<CartModel>();
                       
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("enter the items from the cart A or B or C or D");
                string type = Console.ReadLine();
                CartModel _items = new CartModel(type);
                items.Add(_items);
            }
            Program p = new Program();
            int totalPrice = p.GetCheckoutPrice(items);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }

        public  int GetCheckoutPrice(List<CartModel> items)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            int sum = 0;
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
            sum= totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

            if ((CounterofC>0 && CounterofD >0))
                {
                int C = CounterofC;
                int D = CounterofD;
                int DiscountofCandD = 0;
                for(int i=0;i<C+D;i--)
                {
                    if(CounterofC ==0 || CounterofD ==0 )
                    {
                        break;
                    }
                    CounterofC--;
                    CounterofD--;
                    DiscountofCandD++;
                }
                sum = sum -( DiscountofCandD*5);
            }

            return sum;
        }
    }
}
