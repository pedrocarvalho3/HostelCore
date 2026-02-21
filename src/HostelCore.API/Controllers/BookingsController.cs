using HostelCore.Application.DTOs;
using HostelCore.Application.Interfaces;
using HostelCore.Application.Services;
using HostelCore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HostelCore.API.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateBookingDto dto)
        {
            await _bookingService.CreateAsync(dto);
            return Created("", null);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var bookings = await _bookingService.GetAllAsync();
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var booking = await _bookingService.GetByIdAsync(id);

            if (booking == null)
                return NotFound();

            return Ok(booking);
        }
    }
}