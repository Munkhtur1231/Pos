//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PosControl
//{
//    public class OrderedProductList
//    {
//        public List<OrderedProduct> OrderedProducts;
//        public double TotalPrice
//        {
//            get
//            {
//                double total = 0;
//                foreach (var product in OrderedProducts)
//                {
//                    total += product.TotalPrice;
//                }
//                return total;
//            }
//        }
//        public OrderedProductList()
//        {
//            OrderedProducts = new List<OrderedProduct>();
//        }

//        public void addOrderedProduct(OrderedProduct product)
//        {
//            OrderedProducts.Add(product);
//        }
//    }
//}
