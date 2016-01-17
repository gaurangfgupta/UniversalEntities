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

        //string Full { get; set; }
    }

    public class PersonName : IPersonName
    {

        public string First { get; set; }

        public string Last { get; set; }

        public string Middle { get; set; }

        public string Title { get; set; }
    }
}
