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
        /// <summary>
        /// Title of a person
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// First name of a person or name of an organization
        /// </summary>
        public string First { get; set; }

        /// <summary>
        /// Last name or family name of a person
        /// </summary>
        public string Last { get; set; }

        /// <summary>
        /// Middle name of a person
        /// </summary>
        public string Middle { get; set; }

    }
}
