using HostelCore.Application.DTOs;
using HostelCore.Application.Interfaces;
using HostelCore.Application.Responses;
using HostelCore.Domain.Entities;
using HostelCore.Domain.Interfaces;

namespace HostelCore.Application.Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public async Task CreateAsync(CreateBookingDto dto)
        {
            if (dto.CheckoutDate <= dto.CheckinDate)
                throw new Exception("Checkout must be after checkin.");

            var booking = new Booking
            {
                Id = Guid.NewGuid(),
                GuestId = dto.GuestId,
                RoomId = dto.RoomId,
                CheckinDate = dto.CheckinDate,
                CheckoutDate = dto.CheckoutDate,
                Status = BookingStatus.Reserved,
            };
            await _bookingRepository.AddAsync(booking);
        }

        public async Task<List<BookingResponseDto>> GetAllAsync()
        {
            var bookings = await _bookingRepository.GetAllAsync();

            return bookings.Select(b => new BookingResponseDto
            {
                Id = b.Id,
                CheckinDate = b.CheckinDate,
                CheckoutDate = b.CheckoutDate,
                Status = b.Status,
                GuestName = b.Guest.Name,
                RoomCode = b.Room.Code
            }).ToList();
        }

        public async Task<BookingResponseDto> GetByIdAsync(Guid id)
        {
            var booking = await _bookingRepository.GetByIdAsync(id);

            if (booking == null)
                return null;

            return new BookingResponseDto
            {
                Id = booking.Id,
                CheckinDate = booking.CheckinDate,
                CheckoutDate = booking.CheckoutDate,
                Status = booking.Status,
                GuestName = booking.Guest.Name,
                RoomCode = booking.Room.Code
            };
        }
    }
}