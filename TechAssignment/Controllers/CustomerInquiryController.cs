using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechnicalAssignment.Entities.ViewDataModel;
using TechnicalAssignment.IRepository;

namespace TechnicalAssignment.Controllers
{
 
    [ApiController]

    

    public class CustomerInquiryController : ControllerBase
    {
        private ICustomerInquiry _repository;

        public CustomerInquiryController(ICustomerInquiry repository)
        {
           
            _repository = repository;
        }

      
      
        [Route("api/CustomerInquiry/GetCustomerWithRecentTransactions")]
        [HttpPost]
        public IActionResult GetCustomerWithRecentTransactions  ([FromBody] CustomerInquiryInputViewModel input )
        {
            try
            {
                if (input==null)
                {
                    return BadRequest("No inquiry criteria");
                }

                if (ModelState.IsValid)
                {

                    
                    var customerDetails = _repository.GetCustomerTransaction(input);
                    if (customerDetails.CustomerId==null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        return Ok(customerDetails);
                    }
                }
                else if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return BadRequest();




            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error");
            }
        }


    }


}