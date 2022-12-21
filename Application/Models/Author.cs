using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Author
    {
        [Key]
        [Required]
        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public DateTime Dob { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}