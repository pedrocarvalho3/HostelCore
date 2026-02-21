using HostelCore.Application.DTOs;
using HostelCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Application.Interfaces
{
    public interface IRoomService
    {
        Task CreateAsync(CreateRoomDto dto);
        Task<List<Room>> GetAllAsync();
        Task<Room> GetByIdAsync(Guid id);
    }
}
