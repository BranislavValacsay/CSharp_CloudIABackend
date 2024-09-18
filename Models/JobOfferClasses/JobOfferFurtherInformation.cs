namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferFurtherInformation
    {
        public string JobGuid { get; set; }
        public string FurtherInformation { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
