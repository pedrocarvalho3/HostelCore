using HostelCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Domain.Interfaces
{
    public interface IBookingRepository
    {
        Task AddAsync(Booking booking);
        Task<List<Booking>> GetAllAsync();
        Task<Booking> GetByIdAsync(Guid id);
    }
}
