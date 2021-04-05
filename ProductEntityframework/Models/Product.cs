using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductEntityframework.Models
{

        public enum Supplier { S001 , S002, S003, S004  }
        public class Product
        {
            [Key]
            public int Id { get; set; }
            [Required]
            [MaxLength(20, ErrorMessage = "Max Length is 20")]
            [MinLength(6, ErrorMessage = "Min Length is 6")]
            public string Name { get; set; }

            [Required]
            [Range(100, 1000, ErrorMessage = "Range between 0 and 100")]
            public int QntyInStock { get; set; }
            [Required]
            public string Description { get; set; }

            [Required]
            public Supplier Supplier { get; set; }

            [DataType(DataType.Date)]
            [DateGreaterThanToday]
            public DateTime DateOfPurchase { get; set; }
        }
    
}