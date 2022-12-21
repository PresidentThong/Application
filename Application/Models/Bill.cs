using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Bill
    {
        [Key]
        [Required]
        public int BillId { get; set; }

        public int ProductId { get; set; }

        public string Quantity { get; set; }

        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
    }
}