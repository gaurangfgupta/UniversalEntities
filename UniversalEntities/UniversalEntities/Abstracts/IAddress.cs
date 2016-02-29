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

        /// <summary>
        /// Returns the whole address in string form. Properties with null, empty or whitespace values are left out
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder addressBuilder = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(Line1))
            {
                addressBuilder.Append(Line1);
                addressBuilder.Append(System.Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(Line2))
            {
                addressBuilder.Append(Line2);
                addressBuilder.Append(System.Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(Line3))
            {
                addressBuilder.Append(Line3);
                addressBuilder.Append(System.Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(City))
            {
                addressBuilder.Append(City);
                addressBuilder.Append(System.Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(PinCode))
            {
                addressBuilder.Append(PinCode);
                addressBuilder.Append(System.Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(State))
            {
                addressBuilder.Append(State);
                addressBuilder.Append(System.Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(Country))
            {
                addressBuilder.Append(Country);
                addressBuilder.Append(System.Environment.NewLine);
            }
            string address = addressBuilder.ToString().Trim();
            addressBuilder = null;
            return address;
        }
    }
}
