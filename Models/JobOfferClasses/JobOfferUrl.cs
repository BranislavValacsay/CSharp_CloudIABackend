namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferUrl
    {
        public string JobGuid { get; set; }
        public string JobUrl { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
