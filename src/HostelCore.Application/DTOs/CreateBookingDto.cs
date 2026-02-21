using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Application.DTOs
{
    public class CreateBookingDto
    {
        public Guid GuestId { get; set; }

        public Guid RoomId { get; set; }

        public DateTime CheckinDate { get; set; }

        public DateTime CheckoutDate { get; set; }
    }
}
