using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamProjectFinal.Models
{
    public class ProductViewModel
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [Required]
        [StringLength(100)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Range(0, 1000000000)]
        [DataType(DataType.Currency)]
        [Display(Name = "Product Price")]
        public double Price { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        [StringLength(32767)]
        [Display(Name = "Product Description")]
        public string Description { get; set; }

        [StringLength(90)]
        [Display(Name = "Name of Seller")]
        public string Owner { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}