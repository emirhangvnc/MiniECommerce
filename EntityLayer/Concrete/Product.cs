using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string ProductName { get; set; }
        [StringLength(1000)]
        public string ProductDescription { get; set; }
        public string? Url { get; set; }
        public decimal? ListPrice { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        [Required]
        public int TaxId { get; set; }
        [ForeignKey("TaxId")]
        public Tax Tax { get; set; }

        [Required]
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
    }
}
