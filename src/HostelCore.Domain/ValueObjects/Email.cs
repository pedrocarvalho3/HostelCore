using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HostelCore.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Address { get; }

        public Email(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Email cannot be empty.");

            if (!Regex.IsMatch(address, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new ArgumentException("Invalid email format.");

            Address = address;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Address;
        }

        public override string ToString() => Address;
    }
}
