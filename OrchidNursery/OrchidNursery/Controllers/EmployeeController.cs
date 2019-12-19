using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrchidModel.Interfaces;

namespace OrchidNursery.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployee _employeerepo;
        public EmployeeController(IEmployee repo)
        {
            _employeerepo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var employes = _employeerepo.GetEmployees();
            return Ok(employes);
        }

        
    }
}