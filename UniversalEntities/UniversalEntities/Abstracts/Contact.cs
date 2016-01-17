using System;
using System.Collections.Generic;

namespace UniversalEntities
{
    public abstract class Contact : IMobiles, IPhones, IEmails
    {
        public PersonName Name { get; set; }
        public List<Address> Addresses { get; set; }
        public List<string> Phones { get; set; }
        public List<string> Mobiles { get; set; }
        public List<string> Emails { get; set; }
    }
}