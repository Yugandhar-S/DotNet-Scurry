using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProductWebsite.Models
{
    public class Product
    {
        
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage="Please Enter Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage="Enter Quantity")]
        public int Quantity { get; set; }
        [Required(ErrorMessage="Please Enter Price")]
        public int Price { get; set; }

    }
}
