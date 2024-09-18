using System.Collections.Generic;

namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferPrimarySkill
    {
        public string JobGuid { get; set; }
        public JobOffer JobOffer { get; set; }

        public int TechStackId { get; set; }
        public ENUM_JobTechStack TechStack { get; set; }
    }
}
