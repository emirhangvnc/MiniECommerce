using CoreLayer.Entities;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Tax : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal TaxValue { get; set; }
    }
}