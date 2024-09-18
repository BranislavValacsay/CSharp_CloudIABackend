namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferSeenCount
    {
        public string JobGuid { get; set; }
        public int SeenCount { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
