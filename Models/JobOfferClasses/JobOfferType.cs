namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferType
    {
        public string JobGuid { get; set; }
        public JobOffer JobOffer { get; set; }

        public int JobTypeId { get; set; }
        public ENUM_JobType JobType { get; set; }
    }
}
