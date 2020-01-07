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
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployee _employerepo;
        private readonly IEmployee employe;

        public EmployeeController(IEmployee repo)
        {
            _employerepo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var Employess = _employerepo.GetEmployees();
            return Ok(Employess);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployeeByID(int EmplyID)
        {
            if (EmplyID < 0)
            {
                BadRequest();
            }
            var Employess = _employerepo.GetEmployeeByID(EmplyID);
            return Ok(Employess);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id < 0)
            {
                return BadRequest();
            }
            _employerepo.DeleteEmployee(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] Employee newobj) //Create New Orchid
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (newobj == null)
            {
                return BadRequest();
            }
            _employerepo.CreateEmployee(newobj);

            return NoContent();
        }

        [HttpPut("{id}")] //Update Method
        public IActionResult UpdateEmployee(int ID, [FromBody] Employee newobj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if (ID < 0)
            {
                return BadRequest();
            }
            int result = _employerepo.UpdateEmployee(ID, newobj);
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