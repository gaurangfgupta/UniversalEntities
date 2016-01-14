using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalEntities.Abstracts
{
    class DetailedPerson:Contact
    {
        public PersonName HusbandFatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Age { get; set; }
        public string Sex { get; set; }
        public string Religion { get; set; }
        public string MaritalStatus { get; set; }
        public DateTime DateOfRegistration { get; set; }
        
    }
}
