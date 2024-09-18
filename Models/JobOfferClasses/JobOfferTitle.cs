namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferTitle
    {
        public string JobGuid { get; set; }
        public string JobTitle { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
