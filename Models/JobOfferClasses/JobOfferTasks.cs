namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferTasks
    {
        public string JobGuid { get; set; }
        public string JobTasks { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
