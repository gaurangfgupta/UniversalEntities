using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities.Interfaces
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
}
