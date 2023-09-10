using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Menu : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string MenuName { get; set; }

        public int? ParentId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public int? CategoryId { get; set; }
    }
}