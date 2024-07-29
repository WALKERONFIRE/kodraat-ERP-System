using Microsoft.AspNetCore.Mvc;
using Oceantecsa.Domain.Models;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.Interfaces;
using Oceantecsa.Infrastructure.IdentityServices;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShelfController : ControllerBase
    {
        private readonly IShelfService _shelfService;

        public ShelfController(IShelfService shelfService)
        {
            _shelfService = shelfService;
        }

        [HttpGet("AllShelves")]
        public ActionResult GetAllShelves()
        {
            var shelves = _shelfService.GetAllShelves();
            return Ok(shelves);
        }

        [HttpGet("Shelf")]
        public ActionResult GetShelf(int id)
        {
            var shelf = _shelfService.GetShelf(id);
            if (shelf != null)
            {
                return Ok(shelf);
            }
            return BadRequest();
        }

        [HttpPost("AddShelf")]
        public ActionResult AddShelf(ShelfDTO shelf)
        {
            _shelfService.AddShelf(shelf);
            return Ok();
        }

        [HttpDelete("DeleteShelf")]
        public ActionResult DeleteShelf(int id)
        {
            _shelfService.DeleteShelf(id);
            return Ok();
        }

        [HttpPut("UpdateShelf")]
        public ActionResult UpdateShelf(int id, ShelfDTO shelf)
        {
            _shelfService.UpdateShelf(id, shelf);
            return Ok();
        }
    }
}
