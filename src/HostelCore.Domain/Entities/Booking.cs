using HostelCore.Domain.ValueObjects;

namespace HostelCore.Domain.Entities
{
    public class Booking
    {
        public Guid Id { get; set; }

        public Guid GuestId { get; set; }
        public Guid RoomId { get; set; }

        public DateRange Period { get; set; } = null!;

        public BookingStatus Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guest Guest { get; set; } = null!;
        public Room Room { get; set; } = null!;
    }

    public enum BookingStatus
    {
        Reserved = 1,
        CheckedIn = 2,
        CheckedOut = 3,
        Canceled = 4
    }
}
