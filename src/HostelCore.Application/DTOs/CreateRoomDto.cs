using HostelCore.Domain.Entities;

namespace HostelCore.Application.DTOs
{
    public class CreateRoomDto
    {
        public string Code { get; set; } = null!;
        public string Type { get; set; } = null!;
        public int Status { get; set; }
    }
}
