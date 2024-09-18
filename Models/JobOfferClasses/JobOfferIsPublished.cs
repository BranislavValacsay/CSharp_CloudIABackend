namespace CloudIABackend.Models
{
    public class JobOfferIsPublished
    {
        public string JobGuid { get; set; }
        public JobOffer JobOffer { get; set; }
        public bool? IsPublished { get; set; }
    }
}
