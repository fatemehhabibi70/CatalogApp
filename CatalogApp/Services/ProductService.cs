using CatalogApp.Models;
using CatalogApp.Services.Contracts;

namespace CatalogApp.Services
{
    public class ProductService : IProductService
    {
        public async Task<IEnumerable<Product>> SearchProductsAsync(ProductForSearch requestData)
        {
            await Task.Delay(2000);
            var products = new List<Product>
        {
            new Product {Id = 1, Name = "N1", Price = 100, Description = "Desc1"},
            new Product {Id = 2, Name = "N2", Price = 200, Description = "Desc2"},
            new Product {Id = 2, Name = "N2", Price = 200, Description = "Desc2"},
        };
            return await Task.FromResult(products);
        }
    }
}
