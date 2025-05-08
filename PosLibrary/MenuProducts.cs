using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PosLibrary
{
    public class MenuProducts
    {
        /// <summary>
        /// Барааны жагсаалт
        /// </summary>
        public List<Product> products;

        public MenuProducts()
        {
            products = new List<Product>();
        }
        /// <summary>
        /// Бараа нэмэх
        /// </summary>
        /// <param name="product">Бараа</param>
        public void addProduct(Product product)
        {
            products.Add(product);
        }
        /// <summary>
        /// Нэрээр хайх
        /// </summary>
        /// <param name="name">Барааны нэр</param>
        /// <returns>Бараа</returns>
        public List<Product> getByName(string name)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Name.ToLower().StartsWith(name.ToLower())) filteredProducts.Add(product);
            }
            return filteredProducts;
        }
        /// <summary>
        /// Төрлөөр хайх
        /// </summary>
        /// <param name="type">Барааны нэр</param>
        /// <returns>Бараа</returns>
        public List<Product> getByType(string type)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Type.ToLower().Equals(type.ToLower())) filteredProducts.Add(product);
            }
            return filteredProducts;
        }
        /// <summary>
        /// Барааны жагсаалтын төрлийг буцаах
        /// </summary>
        /// <returns>Барааны жагсаалт</returns>
        public List<string> getTypes()
        {
            return products
                .Where(p => p.Type != null)
                .Select(p => p.Type)
                .Distinct()
                .ToList();
        }
    }
}
