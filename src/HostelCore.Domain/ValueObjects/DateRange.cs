using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Domain.ValueObjects
{
    public class DateRange : ValueObject
    {
        public DateTime Checkin { get; }
        public DateTime Checkout { get; }

        public DateRange(DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
                throw new ArgumentException("Checkout must be after checkin.");

            Checkin = checkin;
            Checkout = checkout;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Checkin;
            yield return Checkout;
        }
    }
}
