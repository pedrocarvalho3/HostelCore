namespace HostelCore.Domain.Entities
{
    public class Room
    {
        public Guid Id { get; set; }

        public string Code { get; set; } = null!;
        public string Type { get; set; } = null!; 

        public RoomStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }

    public enum RoomStatus
    {
        Available = 1,
        Occupied = 2,
        Maintenance = 3
    }
}
