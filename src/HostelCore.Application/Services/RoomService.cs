using HostelCore.Application.DTOs;
using HostelCore.Domain.Entities;
using HostelCore.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Application.Services
{
    public class RoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public async Task CreateAsync(CreateRoomDto dto)
        {
            var room = new Room
            {
                Id = Guid.NewGuid(),
                Code = dto.Code,
                Type = dto.Type,
                Status = (RoomStatus)dto.Status
            };
            await _roomRepository.AddAsync(room);
        }

        public async Task<List<Room>> GetAllAsync()
        {
            return await _roomRepository.GetAllAsync();
        }

        public async Task<Room> GetByIdAsync(Guid id)
        {
            return await _roomRepository.GetByIdAsync(id);
        }
    }
}
