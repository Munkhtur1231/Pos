using PosLibrary;
using Pos;
using Microsoft.EntityFrameworkCore;
using Pos.data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;
using Microsoft.Identity.Client;

namespace PosTest
{
    [TestClass]
    public sealed class Test1
    {
        SqliteConnection connection;
        public ProductsContext productContext = new ProductsContext();


        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        public void AddProduct()
        {
            Product product = new Product
            {
                Name = "product_name",
                Price = 9999,
                Type = "Drink",
                Image = null
            };

            productContext.Products.Add(product);
            productContext.SaveChanges();

            var savedProduct = productContext.Products.FirstOrDefault(p => p.Name == "product_name");
            Assert.IsNotNull(savedProduct);
            Assert.AreEqual(9999, savedProduct.Price);
        }

        [TestMethod]
        public void DeleteProduct()
        {
            var product = new Product
            {
                Name = "product_to_delete",
                Price = 500,
                Type = "Snack",
                Image = null
            };
            productContext.Products.Add(product);
            productContext.SaveChanges();

            var productToDelete = productContext.Products.FirstOrDefault(p => p.Name == "product_to_delete");
            if (productToDelete != null)
            {
                productContext.Products.Remove(productToDelete);
                productContext.SaveChanges();
            }

            var deletedProduct = productContext.Products.FirstOrDefault(p => p.Name == "product_to_delete");
            Assert.IsNull(deletedProduct);
        }

        [TestMethod]
        public void UpdateProduct()
        {
            var product = new Product
            {
                Name = "OldName",
                Price = 10.0,
                Type = "Food",
                Image = null
            };
            productContext.Products.Add(product);
            productContext.SaveChanges();

            var productToUpdate = productContext.Products.FirstOrDefault(p => p.Name == "OldName");
            if (productToUpdate != null)
            {
                productToUpdate.Name = "NewName";
                productToUpdate.Price = 15.0;
                productContext.SaveChanges();
            }

            var updatedProduct = productContext.Products.FirstOrDefault(p => p.Name == "NewName");
            Assert.IsNotNull(updatedProduct);
            Assert.AreEqual(15.0, updatedProduct.Price);
            Assert.AreEqual("NewName", updatedProduct.Name);
        }


        [TestMethod]
        public void AddMenuProduct()
        {
            var menu = new MenuProducts();
            var product = new Product { Id = 1, Name = "Coffee", Price = 5.0, Type = "Drink" };
            menu.addProduct(product);
            Assert.AreEqual(1, menu.products.Count);
            Assert.AreEqual("Coffee", menu.products[0].Name);
        }

        [TestMethod]
        public void RemoveMenuProduct()
        {
            var menu = new MenuProducts();
            var product = new Product { Id = 1, Name = "Coffee", Price = 5.0, Type = "Drink" };
            menu.addProduct(product);
            menu.products.Remove(product);
            Assert.AreEqual(0, menu.products.Count);
        }

        [TestMethod]
        public void GetProductByName()
        {
            var menu = new MenuProducts();
            var product = new Product { Id = 1, Name = "Coffee", Price = 5.0, Type = "Drink" };
            menu.addProduct(product);

            var results = menu.getByName("Coffee");

            Assert.AreEqual(1, results.Count);
            Assert.AreEqual("Coffee", results[0].Name);
        }

        [TestMethod]
        public void CanGetProductByType()
        {
            var menu = new MenuProducts();
            menu.addProduct(new Product { Name = "Tea", Price = 2.0, Type = "Drink" });
            menu.addProduct(new Product { Name = "Cake", Price = 3.0, Type = "Dessert" });

            var drinks = menu.getByType("Drink");

            Assert.AreEqual(1, drinks.Count);
            Assert.AreEqual("Tea", drinks[0].Name);
        }
        [TestMethod]
        public void AddOrderedProduct()
        {
            var list = new OrderedProductList();
            var product = list.addOrderedProduct(1, "Latte", 1, 4.5);

            Assert.IsTrue(list.isOrdered(1));
            Assert.AreEqual(4.5, list.TotalPrice);
        }

        [TestMethod]
        public void RemoveOrderedProduct()
        {
            var list = new OrderedProductList();
            var product = list.addOrderedProduct(1, "Latte", 1, 4.5);

            list.removeOrderedProduct(product);
            Assert.AreEqual(0, list.TotalPrice);
        }

        [TestMethod]
        public void CanFilterProductsByType()
        {
            var menu = new MenuProducts();
            menu.addProduct(new Product { Name = "Burger", Price = 4.0, Type = "Food" });
            menu.addProduct(new Product { Name = "Soda", Price = 1.0, Type = "Drink" });

            var food = menu.getByType("Food");

            Assert.AreEqual(1, food.Count);
            Assert.AreEqual("Burger", food[0].Name);
        }

        [TestMethod]
        public void PaymentTest()
        {
            var payment = new Payment();
            payment.TotalPrice = 5000;
            payment.PaidAmount = 11000;
            payment.calc();
            Assert.AreEqual(6000, payment.Change);
        }

        [TestMethod]
        public void FullTest()
        {
            // Create
            var product = new Product
            {
                Name = "ComboMeal",
                Price = 12.5,
                Type = "Food",
                Image = null
            };

            // Add
            productContext.Products.Add(product);
            productContext.SaveChanges();

            var savedProduct = productContext.Products.FirstOrDefault(p => p.Name == "ComboMeal");
            Assert.IsNotNull(savedProduct);
            Assert.AreEqual(12.5, savedProduct.Price);

            // Update
            savedProduct.Name = "ComboMealUpdated";
            savedProduct.Price = 15.0;
            productContext.SaveChanges();

            var updatedProduct = productContext.Products.FirstOrDefault(p => p.Name == "ComboMealUpdated");
            Assert.IsNotNull(updatedProduct);
            Assert.AreEqual(15.0, updatedProduct.Price);

            // Get By Name and Type
            var menu = new MenuProducts();
            menu.addProduct(updatedProduct);

            var byName = menu.getByName("ComboMealUpdated");
            Assert.AreEqual(1, byName.Count);
            Assert.AreEqual("ComboMealUpdated", byName[0].Name);

            var byType = menu.getByType("Food");
            Assert.IsTrue(byType.Any(p => p.Name == "ComboMealUpdated"));

            // OrderedProductList
            var orderedList = new OrderedProductList();
            orderedList.addOrderedProduct(1, "ComboMealUpdated", 2, 15.0);

            Assert.IsTrue(orderedList.isOrdered(1));
            Assert.AreEqual(30.0, orderedList.TotalPrice);

            // Delete
            productContext.Products.Remove(updatedProduct);
            productContext.SaveChanges();

            var deletedProduct = productContext.Products.FirstOrDefault(p => p.Name == "ComboMealUpdated");
            Assert.IsNull(deletedProduct);
        }
    }
}
