using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class ProductDetails
    {
        public string Name { set; get; }
        public double Price { set; get; }
        public int Quantity { set; get; }
        public string Type { set; get; }

        public ProductDetails(string name, double price, int quantity, string type)
        {
            this.Name = name;

            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }

        public override string ToString()
        {
            return string.Format("Name:{0}\t Price:{1}\t Quantity:{2}\t Type:{3}\n", Name, Price, Quantity, Type);
        }

        public void GetData()
        {
            Console.WriteLine("{0},{1},{2},{3}", Name, Price, Quantity, Type);
        }
    }
}
