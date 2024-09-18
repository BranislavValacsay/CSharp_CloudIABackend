namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferState
    {
        public string JobGuid { get; set; }
        public JobOffer JobOffer { get; set; }

        public int JobStateId { get; set; }
        public ENUM_JobState JobState { get; set; }
    }
}
