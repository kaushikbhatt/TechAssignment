using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TechnicalAssignment.Entities.ViewDataModel
{
    public class CustomerInquiryInputViewModel
    {
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        [StringLength(10,MinimumLength =10, ErrorMessage = "Please enter valid Number")]
        public string CustomerId { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
