using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class ProductAndImage : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(300)]
        public string? FileName { get; set; }
        [StringLength(300)]
        public string? FilePath { get; set; }

        [Required]
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}