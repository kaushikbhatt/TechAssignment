using System;

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TechnicalAssignment.Entities.Model;
using TechnicalAssignment.Entities.ViewDataModel;
namespace TechnicalAssignment.IRepository
{
    public interface ICustomerInquiry : IBase<Customer>
    {
       CustomerInquiryViewModel GetCustomerTransaction(CustomerInquiryInputViewModel input);
    }
}


