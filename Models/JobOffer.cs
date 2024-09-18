using System.Collections.Generic;

namespace CloudIABackend.Models
{
    public class JobOffer
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string JobTitle { get; set; }
        public string Language { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string JobType { get; set; }
        public string JobDescription { get; set; }
        public string YourProfile { get; set; }
        public string YouCanExpect { get; set; }
        public string FurtherInformation { get; set; }
        public string StartDate { get; set; }
        public int Salary { get; set; }
        public int TimesSeen { get; set; }
        public string Source { get; set; }
        public int SourceId { get; set; }
        public string SourceUrl { get; set; }
        public string Tasks { get; set; }
        public string JobUrl { get; set; }
        public bool JobClosed { get; set; }
        public ICollection<JobOfferTechStack> ClassTechStack { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set; }

    }
}
/*
joboffer -> connClass
Language -> icollection connClass
conClass -> id+offer, id+Language

        public string TitleGuid { get; set; }
        public JobOffer JobOffer { get; set; }
*/