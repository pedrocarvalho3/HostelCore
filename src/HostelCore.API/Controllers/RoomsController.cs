using HostelCore.Application.DTOs;
using HostelCore.Application.Services;
using HostelCore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HostelCore.API.Controllers
{
    [ApiController]
    [Route("api/rooms")]
    public class RoomsController : ControllerBase
    {
        private readonly RoomService _roomService;

        public RoomsController(RoomService RoomService)
        {
            _roomService = RoomService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateRoomDto dto)
        {
            await _roomService.CreateAsync(dto);
            return Created("", null);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var guests = await _roomService.GetAllAsync();
            return Ok(guests);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var room = await _roomService.GetByIdAsync(id);

            if (room == null)
                return NotFound();

            return Ok(room);
        }
    }
}