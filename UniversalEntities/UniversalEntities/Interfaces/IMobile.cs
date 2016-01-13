using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities
{
    interface IMobile
    {
        string CountryCode { get; set; }
        string Number { get; set; }
    }
}
