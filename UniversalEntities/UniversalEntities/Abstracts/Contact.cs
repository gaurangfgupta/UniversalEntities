using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities
{
    abstract class Contact
    {
        public PersonName Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Mobile> Mobiles  { get; set; }
        public List<Email> Emails { get; set; }

    }
}