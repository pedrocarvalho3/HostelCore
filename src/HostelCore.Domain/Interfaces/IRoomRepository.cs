using HostelCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Domain.Interfaces
{
    public interface IRoomRepository
    {
        Task AddAsync(Room room);
        Task<List<Room>> GetAllAsync();
        Task<Room> GetByIdAsync(Guid id);
    }
}
