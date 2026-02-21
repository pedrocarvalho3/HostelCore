using HostelCore.Application.DTOs;
using HostelCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Application.Interfaces
{
    public interface IGuestService
    {
        Task CreateAsync(CreateGuestDto dto);
        Task<List<Guest>> GetAllAsync();
        Task<Guest> GetByIdAsync(Guid id);
    }
}
