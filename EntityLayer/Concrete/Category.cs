using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string CategoryName { get; set; }
        public string? Url { get; set; }
        public int? ParentId { get; set; }
    }
}