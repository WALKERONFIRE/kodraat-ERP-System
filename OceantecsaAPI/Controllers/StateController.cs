using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Domain.Models;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateServices _stateServices;

        public StateController(IStateServices stateServices)
        {
            _stateServices = stateServices;
        }

        [HttpGet("GetAllStates")]
        public IActionResult GetAllStates()
        {
            var states = _stateServices.GetAllStates();
            return Ok(states);
        }

        [HttpGet("GetState")]
        public IActionResult GetState(int id)
        {
            var state = _stateServices.GetState(id);
            if (state == null)
                return NotFound();

            return Ok(state);
        }

        [HttpPost("AddState")]
        public IActionResult AddState(StateDTO state)
        {
            _stateServices.AddState(state);
            return Ok();
        }

        [HttpPut("UpdateState")]
        public IActionResult UpdateState(int id, StateDTO state)
        {
            var updated = _stateServices.UpdateState(id, state);
            if (!updated)
                return NotFound();

            return Ok();
        }

        [HttpDelete("RemoveState")]
        public IActionResult RemoveState(int id)
        {
            var removed = _stateServices.RemoveState(id);
            if (!removed)
                return NotFound();

            return Ok();
        }
    }
}
