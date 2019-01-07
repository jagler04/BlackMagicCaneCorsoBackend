using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlackMagicCaneCorsoBackend.Models
{
    public class RegistrationForm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool Pronunciation { get; set; }
        public bool CompanyHome { get; set; }
        public string PreferedGender { get; set; }
        public int ShowCompetition { get; set; }
        public int AgilityCompetition { get; set; }
        public int TherapyDog { get; set; }
        public int EmotionalSupport { get; set; }
        public int Breeding { get; set; }
        public int CouchBuddy { get; set; }

    }
}
