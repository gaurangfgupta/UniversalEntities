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

        void IsCorrectFormat();
    }
    public class Address : IAddress
    {
        private string line1;
        private string line2;
        private string line3;
        private string city;
        private string pinCode;
        private string state;
        private string country;

        public string Line1 { get { return line1; } set { line1 = value.Trim(); } }

        public string Line2 { get { return line2; } set { line2 = value.Trim(); } }

        public string Line3 { get { return line3; } set { line3 = value.Trim(); } }

        public string City { get { return city; } set { city = value.Trim(); } }

        public string PinCode { get { return pinCode; } set { pinCode = value.Trim(); } }

        public string State { get { return state; } set { state = value.Trim(); } }

        public string Country { get { return country; } set { country = value.Trim(); } }

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
                addressBuilder.Append(Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(Line2))
            {
                addressBuilder.Append(Line2);
                addressBuilder.Append(Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(Line3))
            {
                addressBuilder.Append(Line3);
                addressBuilder.Append(Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(City))
            {
                addressBuilder.Append(City);
                addressBuilder.Append(Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(PinCode))
            {
                addressBuilder.Append(PinCode);
                addressBuilder.Append(Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(State))
            {
                addressBuilder.Append(State);
                addressBuilder.Append(Environment.NewLine);
            }
            if (!string.IsNullOrWhiteSpace(Country))
            {
                addressBuilder.Append(Country);
                addressBuilder.Append(Environment.NewLine);
            }
            string address = addressBuilder.ToString().Trim();
            addressBuilder = null;
            return address;
        }

        public void IsCorrectFormat()
        {
            string errorMessage = "First preference to Line 1, then Line 2 followed by Line 3";
            if (string.IsNullOrWhiteSpace(Line1))
            {
                if (!string.IsNullOrWhiteSpace(Line2) || !string.IsNullOrWhiteSpace(Line3))
                {
                    throw new ArgumentException(errorMessage);
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Line2) && !string.IsNullOrWhiteSpace(Line3))
                {
                    throw new ArgumentException(errorMessage);
                }
            }

        }

        public void SortAddressLines()
        {
            string[] addressLines = new string[] { Line1, Line2, Line3 };
            for (int i = 0; i < addressLines.Length - 1; i++)
            {
                for (int j = i + 1; j < addressLines.Length; j++)
                {
                    if (string.IsNullOrWhiteSpace(addressLines[i]))
                    {
                        string temp = addressLines[i];
                        addressLines[i] = addressLines[j];
                        addressLines[j] = temp;
                    }
                }
            }
            Line1 = addressLines[0];
            Line2 = addressLines[1];
            Line3 = addressLines[2];
        }

    }
}
