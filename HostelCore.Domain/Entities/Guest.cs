namespace HostelCore.Domain.Entities
{
    public class Guest
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Document { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string? Email { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
