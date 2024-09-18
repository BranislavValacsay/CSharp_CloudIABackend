namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferStartDate
    {
        public string JobGuid { get; set; }
        public string StartDate { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
