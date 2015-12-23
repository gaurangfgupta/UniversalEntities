using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities.Interfaces
{
    interface IMobile
    {
        string CountryCode { get; set; }
        string Number { get; set; }
        string StdCode { get; set; }
    }
}
