using CatalogApp.Models;

namespace CatalogApp.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> SearchProductsAsync(ProductForSearch requestData);
    }
}
