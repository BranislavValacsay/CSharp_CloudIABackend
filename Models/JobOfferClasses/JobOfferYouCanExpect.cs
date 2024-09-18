namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferYouCanExpect
    {
        public string JobGuid { get; set; }
        public string YouCanExpect { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
