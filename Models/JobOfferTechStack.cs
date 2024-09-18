namespace CloudIABackend.Models
{
    public class JobOfferTechStack
    {
        public string JobGuid { get; set; }
        public JobOffer JobOffer { get; set; }

        public int TechStackSkillId { get; set; }
        public ENUM_JobTechStack TechStack { get; set; }
    }
}