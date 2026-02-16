using HostelCore.Application.DTOs;
using HostelCore.Domain.Entities;
using HostelCore.Domain.Interfaces;

namespace HostelCore.Application.Services
{
    public class GuestService
    {
        private readonly IGuestRepository _guestRepository;

        public GuestService(IGuestRepository guestRepository)
        {
            _guestRepository = guestRepository;
        }

        public async Task CreateAsync(CreateGuestDto dto)
        {
            var guest = new Guest
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Document = dto.Document,
                Phone = dto.Phone,
                Email = dto.Email
            };
            await _guestRepository.AddAsync(guest);
        }

        public async Task<List<Guest>> GetAllAsync() 
        {
            return await _guestRepository.GetAllAsync();
        }

        public async Task<Guest> GetByIdAsync(Guid id)
        {
            return await _guestRepository.GetByIdAsync(id);
        }
    }
}