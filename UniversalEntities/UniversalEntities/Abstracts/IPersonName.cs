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

        string Full { get; }
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
        /// Middle name of a person
        /// </summary>
        public string Middle { get; set; }

        /// <summary>
        /// Last name or family name of a person
        /// </summary>
        public string Last { get; set; }


        public string Full
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(Middle) && string.IsNullOrWhiteSpace(Last))
                {
                    throw new MemberAccessException("A name cannot have a middle name without last name. Either remove the former or provide the latter.");
                }
                StringBuilder fullName = new StringBuilder();
                fullName.AppendFormat("{0} {1}",Title,First);
                if (!string.IsNullOrWhiteSpace(Middle))
                {
                    fullName.AppendFormat(" {0}", Middle);
                }
                if (!string.IsNullOrWhiteSpace(Last))
                {
                    fullName.AppendFormat(" {0}", Last);
                }
                return fullName.ToString().Trim();
            }
        }
    }
}
