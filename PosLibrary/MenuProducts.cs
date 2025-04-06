using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PosLibrary
{
    public class MenuProducts
    {
        public List<Product> products;

        public MenuProducts()
        {
            products = new List<Product>();
        }
        public void addProduct(Product product)
        {
            products.Add(product);
        }
        public List<Product> getByName(string name)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Name.ToLower().StartsWith(name.ToLower())) filteredProducts.Add(product);
            }
            return filteredProducts;
        }
        public List<Product> getByType(string type)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Type.ToLower().Equals(type.ToLower())) filteredProducts.Add(product);
            }
            return filteredProducts;
        }
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
