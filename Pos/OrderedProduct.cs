using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos
{
    
    public class OrderedProduct
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public int Quantity   { get; set; }
        public double Price { get; set; }
        public double TotalPrice => Price * Quantity;

        public OrderedProduct(double id, string name, int quantity, double price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

}
