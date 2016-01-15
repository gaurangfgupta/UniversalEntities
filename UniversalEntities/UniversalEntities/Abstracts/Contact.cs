using System.Collections.Generic;

namespace UniversalEntities
{
    public abstract class Contact
    {
        public PersonName Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Mobile> Mobiles  { get; set; }
        public List<Email> Emails { get; set; }

    }
}