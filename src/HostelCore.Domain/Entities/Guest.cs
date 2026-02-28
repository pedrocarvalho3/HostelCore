using HostelCore.Domain.ValueObjects;

namespace HostelCore.Domain.Entities
{
    public class Guest
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public Document Document { get; set; } = null!;

        public Phone Phone { get; set; } = null!;

        public Email? Email { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
