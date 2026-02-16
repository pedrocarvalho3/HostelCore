using HostelCore.Domain.Entities;

namespace HostelCore.Domain.Interfaces
{
    public interface IGuestRepository
    {
        Task AddAsync(Guest guest);
        Task<List<Guest>> GetAllAsync();
        Task<Guest> GetByIdAsync(Guid id);
    }
}