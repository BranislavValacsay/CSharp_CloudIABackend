namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferLanguage
    {
        public string JobGuid { get; set; }
        public JobOffer JobOffer { get; set; }

        public int JobLanguageId { get; set; }
        public ENUM_JobLanguage JobLanguage { get; set; }

    }
}
