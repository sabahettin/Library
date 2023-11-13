using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        public Guid categoryCode { get; set; }
        [Required]
        [MaxLength(25)]
        [MinLength(3)]
        public string categoryName { get; set; }
    }
}
