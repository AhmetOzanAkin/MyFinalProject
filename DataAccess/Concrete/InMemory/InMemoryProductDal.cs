using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            // Bir veritabanından geliyormuş gibi simulasyon yapıyoruz.
            _products = new List<Product>
            {
                new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15 },
                new Product { ProductId = 2, CategoryId = 1, ProductName = "Çatal", UnitPrice = 10, UnitsInStock = 25 },
                new Product { ProductId = 3, CategoryId = 2, ProductName = "Kaşık", UnitPrice = 25, UnitsInStock = 10 },
                new Product { ProductId = 4, CategoryId = 2, ProductName = "Bıçak", UnitPrice = 5, UnitsInStock = 30 },
                new Product { ProductId = 5, CategoryId = 2, ProductName = "Klavye", UnitPrice = 50, UnitsInStock = 65 }
            };
            }
        public void Add(Product product)
        {
               _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query 
            // p => Lambda referansı tutan  
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            // Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul ki ben onu güncelleyeyim
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;
        }
    }
}
