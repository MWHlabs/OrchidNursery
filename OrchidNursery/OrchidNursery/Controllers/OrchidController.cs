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
        [HttpGet("{id}")] 
        public IActionResult GetOrchidsID(int ID)
        {
            if (ID < 0)
            {
                BadRequest();
            }

            var orchids = _orchidnewRepo.GetAllOrchidNewByID(ID);
            return Ok(orchids);
        }
        [HttpDelete("{id}")]//Delete Method
        public IActionResult DeleteOrchid(int ID)
        {
            if (ID < 0)
            {
                return BadRequest();
            }
            _orchidnewRepo.DeleteOrchid(ID);
            return Ok();
        }

        [HttpPut("{id}")] //Update Method
        public IActionResult UpdateOrchid(int ID,[FromBody] OrchidNew newobj)
        {
            
            if (ID < 0)
            {
                return BadRequest();
            }
            int result = _orchidnewRepo.UpdateOrchid(ID, newobj);
            if(result == 0)
            {
                return BadRequest();
            }
            else
            {
                return Ok();
            }
        }
        [HttpPost]
        public IActionResult CreateOrchid([FromBody] OrchidNew newobj) //Create New Orchid
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            if(newobj == null)
            {
                return BadRequest();
            }
            _orchidnewRepo.CreateOrchid(newobj);
            return NoContent();
        }
    }
}