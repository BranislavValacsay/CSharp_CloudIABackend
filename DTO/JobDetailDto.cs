//using CloudIABackend.Models.JobOfferClasses;
using System.Collections.Generic;


namespace CloudIABackend.DTO
{
    public class JobDetailDto
    {
        public string JobGuid { get; set; }
        public string JobTitle { get; set; }
        public string Language { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string JobDescription { get; set; }
        public string JobType { get; set; }
        public string YourProfile { get; set; }
        public string YouCanExpect { get; set; }
        public string FurtherInformation { get; set; }
        public string StartDate { get; set; }
        public int Salary { get; set; }        
        public string Tasks { get; set; }
        public string JobUrl { get; set; }
        public ICollection<ENUM_JobTechStacKDTO> TechStack { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set; }
    }
}
