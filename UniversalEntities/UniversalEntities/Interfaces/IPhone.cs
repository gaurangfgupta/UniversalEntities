using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities.Interfaces
{
    interface IPhone
    {
        string CountryCode { get; set; }
        string StdCode { get; set; }
        string Number { get; set; }
    }
}
