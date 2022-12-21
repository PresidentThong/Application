using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int productId { get; set; }

        [Required]
        public string BookName { get; set; }

        public int? Quantity { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public int AuthorId { get; set; }

        [StringLength(50)]
        public string ProductImage { get; set; }

        public virtual Category Category { get; set; }

        public virtual Author Author { get; set; }
    }
}