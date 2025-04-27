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
        public List<OrderedProduct> OrderedProducts;
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

        public OrderedProduct addOrderedProduct(double id, string name, int qty, double price)
        {
            OrderedProduct orderedProduct = new OrderedProduct(id, name, qty, price);
            OrderedProducts.Add(orderedProduct);
            return orderedProduct;
        }
        public void removeOrderedProduct(OrderedProduct product)
        {
            OrderedProducts.Remove(product);
        }
        public void clear()
        {
            OrderedProducts.Clear();
        }
        public bool isOrdered(double id)
        {
            foreach (var product in OrderedProducts)
            {
                if (product.Id == id) return true;
            }
            return false;
        }
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
