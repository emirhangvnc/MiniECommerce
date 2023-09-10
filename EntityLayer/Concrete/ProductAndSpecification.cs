using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class ProductAndSpecification : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }

        [Required]
        [ForeignKey("SpecificationValueId")]
        public SpecificationValue SpecificationValue { get; set; }
        public int SpecificationValueId { get; set; }
    }
}
