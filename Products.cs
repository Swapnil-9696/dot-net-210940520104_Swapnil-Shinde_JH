using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DotNetEndExam.Models
{
    public class Products
    {
        
        
        public int ProductId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter product name..")]
        public string ProductName { get; set; }

        
        public decimal Rate { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter product's Description")]
        public string Description { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter product's Category name")]
        public string CategoryName { get; set; }
    }
}