using HostelCore.Domain.Entities;
using HostelCore.Domain.Interfaces;
using HostelCore.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HostelCore.Infrastructure.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly AppDbContext _context;

        public GuestRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Guest guest)
        {
            _context.Guests.Add(guest);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Guest>> GetAllAsync()
        {
            return await _context.Guests.ToListAsync();
        }

        public async Task<Guest> GetByIdAsync(Guid id)
        {
            return await _context.Guests.FirstOrDefaultAsync(g => g.Id == id);
        }
    }
}
