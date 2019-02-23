using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAssignment.Entities.Model;

namespace TechnicalAssignment.Entities.ViewDataModel
{
    public class CustomerInquiryViewModel
    {
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public IEnumerable<Transactions> Transactions { get; set; }

        public CustomerInquiryViewModel(Customer customer)
        {
            CustomerId = customer.CustomerId;
            Name = customer.CustomerName;
            Email = customer.ContactEmail;
            Mobile = customer.MobileNO;
        }

       
    }
}