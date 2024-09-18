namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferDescription
    {
        public string JobGuid { get; set; }
        public string JobDescription { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
