using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Product_Shop
{
    class ProductShop
    {
        static void Main()
        {

            var dictShopProductPrice = new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Revision")
                {
                    break;
                }

                string[] splitedInput = input.Split(", ");
                string shop = splitedInput[0];
                string product = splitedInput[1];
                decimal price = decimal.Parse(splitedInput[2]);

                if (dictShopProductPrice.ContainsKey(shop) == false)
                {
                    dictShopProductPrice[shop] = new Dictionary<string, decimal>();
                }

                dictShopProductPrice[shop][product] = price;
            }

            Console.WriteLine();

            foreach (var kvp in dictShopProductPrice.OrderBy(x => x.Key))
            {
                string shop = kvp.Key;
                Console.WriteLine($"{shop}->");

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value:f1}");
                }
            }
        }
    }
}
