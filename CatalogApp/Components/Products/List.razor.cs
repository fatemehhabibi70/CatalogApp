using CatalogApp.Models;
using CatalogApp.Services.Contracts;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CatalogApp.Components.Products
{
    public partial class List
    {
        private string _searchText=string.Empty;
        private Product selectedItem1 = null;
        private HashSet<Product> selectedItems = new HashSet<Product>();
      

        [Inject]
        public IProductService productService { get; set; }

        private async Task<TableData<Product>> GetServerDataAsync(TableState tableState)
        {
            
            TableData<Product> output = new();
            ProductForSearch  input = new();
            input.SearchText= _searchText;
            var products = await productService.SearchProductsAsync(input);
            output.Items = products;
            output.TotalItems = products.Count();

            return output;
        }

        private void SearchTextChanged(string searchText)
        {
            if(searchText ==null) { return; }
            _searchText= searchText;

        }



        private bool FilterFunc1(Product Product) => FilterFunc(Product, _searchText);

        private bool FilterFunc(Product product, string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return true;
            if (product!.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                return true;
            return false;
        }
    }
}
