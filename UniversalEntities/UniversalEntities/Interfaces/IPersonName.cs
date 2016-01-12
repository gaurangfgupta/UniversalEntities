using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities
{
    public interface IPersonName
    {
        string Title { get; set; }

        string First { get; set; }

        string Middle { get; set; }

        string Last { get; set; }

        string Full { get; set; }
    }
}
