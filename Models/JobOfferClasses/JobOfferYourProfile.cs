namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferYourProfile
    {
        public string JobGuid { get; set; }
        public string YourProfile { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
