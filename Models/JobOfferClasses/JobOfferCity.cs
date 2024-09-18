namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferCity
    {
        public string JobGuid { get; set; }
        public JobOffer JobOffer { get; set; }

        public int JobCityId { get; set; }
        public ENUM_JobCity JobCity { get; set; }
    }
}
