using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrchidModel.Interfaces;

namespace OrchidNursery.Controllers
{
    [Route("api/orchid")]
    [ApiController]
    public class OrchidController : ControllerBase
    {
        IOrchid _orchidnewRepo;
        public OrchidController(IOrchid repo)
        {
            _orchidnewRepo = repo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var orchids = _orchidnewRepo.GetAllOrchids();
            return Ok(orchids);
        }
        [HttpGet("{id}")] //for the create new orchid flower
        public IActionResult GetOrchidsID(int ID)
        {
            if (ID < 0)
            {
                BadRequest();
            }

            var orchids = _orchidnewRepo.GetAllOrchidNewByID(ID);
            return Ok(orchids);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrchid(int ID)
        {
            if (ID < 0)
            {
                return BadRequest();
            }
            _orchidnewRepo.DeleteOrchid(ID);
            return Ok();
        }
    }
}