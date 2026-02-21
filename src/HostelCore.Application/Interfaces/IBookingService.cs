using HostelCore.Application.DTOs;
using HostelCore.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Application.Interfaces
{
    public interface IBookingService
    {
        Task CreateAsync(CreateBookingDto dto);
        Task<List<BookingResponseDto>> GetAllAsync();
        Task<BookingResponseDto> GetByIdAsync(Guid id);
    }
}
