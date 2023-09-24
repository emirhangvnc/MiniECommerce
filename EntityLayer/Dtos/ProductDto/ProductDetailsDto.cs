using EntityLayer.Concrete;

namespace EntityLayer.Dtos.ProductDto
{
    public class ProductDetailsDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string BrandName { get; set; }
        public decimal TaxValue { get; set; }
        public List<ProductAndImage> productAndImages { get; set; }
    }
}
