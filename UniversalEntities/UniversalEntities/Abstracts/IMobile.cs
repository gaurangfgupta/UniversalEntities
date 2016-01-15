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
    public struct Mobile : IMobile
    {
        public string CountryCode { get; set; }

        public string Number { get; set; }
    }
}
