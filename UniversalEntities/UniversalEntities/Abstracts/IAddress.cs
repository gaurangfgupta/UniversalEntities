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
    public struct Address : IAddress
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string Line1 { get; set; }

        public string Line2 { get; set; }

        public string Line3 { get; set; }

        public string PinCode { get; set; }

        public string State { get; set; }
    }
}
