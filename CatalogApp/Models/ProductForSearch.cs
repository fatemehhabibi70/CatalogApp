namespace CatalogApp.Models
{
    public class ProductForSearch
    {
        public string? SearchText { get; set; }
        public string? Sort { get; set; }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
    }
}
