using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosLibrary
{

    public class OrderedProduct
    {
        /// <summary>
        /// Захиалсан барааны ID
        /// </summary>
        public double Id { get; set; }
        /// <summary>
        /// Захиалсан барааны нэр
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Захиалсан барааны тоо
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Захиалсан барааны үнэ
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Захиалсан барааны нийт үнэ
        /// </summary>
        public double TotalPrice => Price * Quantity;
        /// <summary>
        /// Захиалсан бараа
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">нэр</param>
        /// <param name="quantity">тоо</param>
        /// <param name="price">үнэ</param>
        public OrderedProduct(double id, string name, int quantity, double price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }

}
