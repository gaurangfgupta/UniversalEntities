using System;

namespace UniversalEntities
{
    class DetailedPerson : ContactPersonOrganization
    {
        public PersonName HusbandFatherName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Age { get; set; }
        public Genders Sex { get; set; }
        public Religions Religion { get; set; }
        public MaritalStatuses MaritalStatus { get; set; }
        public DateTime DateOfRegistration { get; set; }
    }
}