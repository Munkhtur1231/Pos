using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PosLibrary;

namespace PosLibrary
{
    public class OrderedProductList
    {
        /// <summary>
        /// Захиалсан Барааны жагсаалт
        /// </summary>
        public List<OrderedProduct> OrderedProducts;
        /// <summary>
        /// Захиалсан Барааны нийт үнэ
        /// </summary>
        public double TotalPrice
        {
            get
            {
                double total = 0;
                foreach (var product in OrderedProducts)
                {
                    total += product.TotalPrice;
                }
                return total;
            }
        }
        public OrderedProductList()
        {
            OrderedProducts = new List<OrderedProduct>();
        }
        /// <summary>
        /// Захиалсан бараа нэмэх
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="name">нэр</param>
        /// <param name="qty">тоо</param>
        /// <param name="price">үнэ</param>
        /// <returns>Захиалсан бараа</returns>

        public OrderedProduct addOrderedProduct(double id, string name, int qty, double price)
        {
            OrderedProduct orderedProduct = new OrderedProduct(id, name, qty, price);
            OrderedProducts.Add(orderedProduct);
            return orderedProduct;
        }
        /// <summary>
        /// Захиалсан бараа хасах
        /// </summary>
        /// <param name="product"></param>
        public void removeOrderedProduct(OrderedProduct product)
        {
            OrderedProducts.Remove(product);
        }
        /// <summary>
        /// Захиалсан бараа жагсаалтыг цэвэрлэх
        /// </summary>
        public void clear()
        {
            OrderedProducts.Clear();
        }
        /// <summary>
        /// Захиалсан бараа байгаа эсэхийг шалгах
        /// </summary>
        /// <param name="id">id</param>
        /// <returns></returns>
        public bool isOrdered(double id)
        {
            foreach (var product in OrderedProducts)
            {
                if (product.Id == id) return true;
            }
            return false;
        }
        /// <summary>
        /// Захиалсан бараа ID-ээр хайх
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public OrderedProduct getById(double id)
        {
            foreach (var product in OrderedProducts)
            {
                if (product.Id == id) return product;
            }
            return null;
        }
    }
}
