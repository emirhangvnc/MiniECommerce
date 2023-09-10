using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SpecificationValue : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Value { get; set; }

        [Required]
        [ForeignKey("SpecificationId")]
        public Specification Specification { get; set; }
        public int SpecificationId { get; set; }
    }
}