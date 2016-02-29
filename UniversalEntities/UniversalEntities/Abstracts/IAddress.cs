using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities
{
    interface IAddress
    {
        string Line1 { get; set; }

        string Line2 { get; set; }

        string Line3 { get; set; }

        string City { get; set; }

        string PinCode { get; set; }

        string State { get; set; }

        string Country { get; set; }
    }
    public class Address : IAddress
    {
        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        public string City { get; set; }

        public string PinCode { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            StringBuilder addressBuilder = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(Line1))
            {
                addressBuilder.AppendLine(Line1);
            }
            if (!string.IsNullOrWhiteSpace(Line2))
            {
                addressBuilder.AppendLine(Line2);
            }
            if (!string.IsNullOrWhiteSpace(Line3))
            {
                addressBuilder.AppendLine(Line3);
            }
            if (!string.IsNullOrWhiteSpace(City))
            {
                addressBuilder.AppendLine(City);
            }
            if (!string.IsNullOrWhiteSpace(PinCode))
            {
                addressBuilder.AppendLine(PinCode);
            }
            if (!string.IsNullOrWhiteSpace(State))
            {
                addressBuilder.AppendLine(State);
            }
            if (!string.IsNullOrWhiteSpace(Country))
            {
                addressBuilder.AppendLine(Country);
            }
            string address = addressBuilder.ToString().Trim();
            addressBuilder = null;
            return address;
        }
    }
}
