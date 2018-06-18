using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            int productCount = 0;
            double totalPrize = 0, avgPrice=0,sum=0;

            List<ProductDetails> product = new List<ProductDetails>();
            List<ProductDetails> CostlyProduct = new List<ProductDetails>();
            List<ProductDetails> ChipProduct = new List<ProductDetails>();

            product.Add(new ProductDetails("lettuce", 10.5, 50, "Leafy green"));
            product.Add(new ProductDetails("cabbage", 20, 100, "Cruciferous"));
            product.Add(new ProductDetails("pumpkin", 30, 30, "Marrow"));
            product.Add(new ProductDetails("cauliflower", 10, 25, "Cruciferous"));
            product.Add(new ProductDetails("zucchini", 20.5, 50, "Marrow"));
            product.Add(new ProductDetails("yam", 30, 50, "Root"));
            product.Add(new ProductDetails("spinach", 10, 100, "Leafy green"));
            product.Add(new ProductDetails("broccoli", 20.2, 75, "Cruciferous"));
            product.Add(new ProductDetails("Garlic", 30, 20, "Leafy green"));
            product.Add(new ProductDetails("silverbeet", 10, 50, "Marrow"));

            foreach (var p in product)
            {
                Console.WriteLine(p);
                productCount += 1;
                sum = sum + p.Price;
            }

            Console.WriteLine("\n Total no of products are:" + productCount);

            foreach (var p in product)
            {
                if (p.Price > 50)
                {
                    CostlyProduct.Add(p);
                }
                else
                {
                    ChipProduct.Add(p);
                }
            }
            Console.WriteLine("\n list of costly product:");
            foreach (var p in CostlyProduct)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n list of chip product:");
            foreach (var p in ChipProduct)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nEnter type of product :");
            type = Console.ReadLine();
            //Console.WriteLine("\n type :" + type);
            foreach (var p in product)
            {
                if (p.Type == type)
                {
                    Console.WriteLine(p);
                }

            }


            foreach (var p in product)
            {
                totalPrize= totalPrize+(p.Price * p.Quantity);
            }
            Console.WriteLine("\nTotal prize of whole inventory:" + totalPrize+" rs.");

            avgPrice = sum / productCount;
            Console.WriteLine("\nAverage product price is :" + avgPrice);
            
        }
    }
}
