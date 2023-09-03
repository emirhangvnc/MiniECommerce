using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace EntityLayer
{
    public class Brand : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string BrandName { get; set; }
    }
}