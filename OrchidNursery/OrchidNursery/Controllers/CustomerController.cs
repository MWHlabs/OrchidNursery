using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrchidModel.Entities;
using OrchidModel.Interfaces;

namespace OrchidNursery.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomer _customerRepo;
        private readonly ICustomer customer;

        public CustomerController(ICustomer repo,ICustomer customer)
        {
            _customerRepo = repo;
            this.customer = customer;
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

        [HttpPost]
        public IActionResult CreateCustomer([FromBody] Customer newobj) //Create New Orchid
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (newobj == null)
            {
                return BadRequest();
            }
            customer.PostCustomer(newobj);
            return NoContent();
        }

        [HttpPut("{id}")] //Update Method
        public IActionResult UpdateCustomer(int ID, [FromBody] Customer newobj)
        {

            if (ID < 0)
            {
                return BadRequest();
            }
            int result = _customerRepo.UpdateCustomer(ID, newobj);
            if (result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }

    }
}