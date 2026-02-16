using HostelCore.Application.DTOs;
using HostelCore.Application.Services;
using HostelCore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HostelCore.API.Controllers
{
    [ApiController]
    [Route("api/guests")]
    public class GuestsController : ControllerBase
    {
        private readonly GuestService _guestService;

        public GuestsController(GuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateGuestDto dto)
        {
            await _guestService.CreateAsync(dto);
            return Created("", null);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var guests = await _guestService.GetAllAsync();
            return Ok(guests);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(Guid id)
        {
            var guest = await _guestService.GetByIdAsync(id);

            if (guest == null)
                return NotFound();

            return Ok(guest);
        }
    }
}