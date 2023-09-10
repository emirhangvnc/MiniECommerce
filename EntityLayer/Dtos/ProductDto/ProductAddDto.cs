using System;

namespace EntityLayer.Dtos.ProductDto
{
    public class ProductAddDto
    {
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int TaxId { get; set; }
        public int BrandId { get; set; }
    }
}