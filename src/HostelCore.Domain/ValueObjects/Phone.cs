using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelCore.Domain.ValueObjects
{
    public class Phone : ValueObject
    {
        public string Number { get; }

        public Phone(string number)
        {
            if (string.IsNullOrWhiteSpace(number))
                throw new ArgumentException("Phone cannot be empty.");

            Number = number;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Number;
        }

        public override string ToString() => Number;
    }
}
