using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalAssignment.Entities;
using TechnicalAssignment.Entities.Model;
using TechnicalAssignment.Entities.ViewDataModel;
using TechnicalAssignment.IRepository;

namespace TechnicalAssignment.Repository
{
    public class CustomerInquiry : Base<Customer>, ICustomerInquiry
    {
        public CustomerInquiry(RepositoryContext repositoryContext)
         : base(repositoryContext)
        {

        }

        public CustomerInquiryViewModel GetCustomerTransaction(CustomerInquiryInputViewModel input)
        {

            if(input.CustomerId == null)
            {
                return new CustomerInquiryViewModel(GetCustomerByEmail(input.Email))
                {
                    Transactions = RepositoryContext.Transactions
                   .Where(a => a.CustomerId == input.CustomerId).OrderByDescending(date => date.TransactionDatetime).Take(5)
                };
            }
            return new CustomerInquiryViewModel(GetCustomerById(input.CustomerId))
          {
                Transactions = RepositoryContext.Transactions
                    .Where(a => a.Status == input.CustomerId).OrderByDescending(date=>date.TransactionDatetime).Take(5)
            };
        }


        public IEnumerable<Customer> GetAllCustomers()
        {
            return FindAll()
                .OrderBy(customer => customer.CustomerName);
        }

        public Customer GetCustomerById(string CustomerId)
        {
            return FindByCondition(Customer => Customer.CustomerId.Equals(CustomerId))
                .DefaultIfEmpty(new Customer())
                .FirstOrDefault();
        }

        public Customer GetCustomerByEmail(string Email)
        {
            return FindByCondition(Customer => Customer.ContactEmail.Equals(Email))
                .DefaultIfEmpty(new Customer())
                .FirstOrDefault();
        }


        public void CreateCustomer(Customer Customer)
        {
        
            Create(Customer);
            Save();
        }

        public void UpdateCustomer(Customer Customer)
        {
         
            Update(Customer);
            Save();
        }

        public void DeleteCustomer(Customer Customer)
        {
            Delete(Customer);
            Save();
        }
    }
}
