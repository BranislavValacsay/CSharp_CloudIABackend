namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferClosed
    {
        public string JobGuid { get; set; }
        public bool? JobClosed { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
