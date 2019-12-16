using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrchidModel.Interfaces;

namespace OrchidNursery.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomer _customerRepo;
        public CustomerController(ICustomer repo)
        {
            _customerRepo = repo;
        }
        [HttpGet] 
        public IActionResult GetAll()
        {
            var Customers = _customerRepo.GetAllCustomer();
            return Ok(Customers);
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomerID(int RegnoID)
        {
            if (RegnoID < 0)
            {
                BadRequest();
            }
            var Customers = _customerRepo.GetCustomerByID(RegnoID);
            return Ok(Customers);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            _customerRepo.DeleteCustomer(id);
            return Ok();
        }

        
    }
}