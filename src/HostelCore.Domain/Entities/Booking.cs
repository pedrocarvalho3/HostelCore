namespace HostelCore.Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }

        public int GuestId { get; set; }
        public int RoomId { get; set; }

        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

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
