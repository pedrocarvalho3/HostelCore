using HostelCore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Application.Responses
{
    public class BookingResponseDto
    {
        public Guid Id { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        public BookingStatus Status { get; set; }

        public string GuestName { get; set; } = null!;
        public string RoomCode { get; set; } = null!;
    }
}
