using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssignment.Entities.Model
{
    [Table("customers")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        [StringLength(10, ErrorMessage = "CustomerId can't be longer than 10 characters")]
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30, ErrorMessage = "Name can't be longer than 30 characters")]
        public string CustomerName { get; set; }

       
        [StringLength(25, ErrorMessage = "Email can't be longer than 25 characters")]
         [EmailAddress(ErrorMessage = "Invalid Email")]
        public string ContactEmail { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        [StringLength(10, ErrorMessage = "Email can't be longer than 10 characters")]
        public string MobileNO { get; set; }



    }
}
