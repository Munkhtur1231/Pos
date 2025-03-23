using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pos
{

    public class Product
    {
        public double Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public string Type { get; set; }
        public Image Image { get; set; }
        public Product(double id, string name, double price, string type, Image image) {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
            Image = image;
        }
    }
}
