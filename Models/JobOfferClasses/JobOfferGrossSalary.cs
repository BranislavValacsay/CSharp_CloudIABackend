namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferGrossSalary
    {
        public string JobGuid { get; set; }
        public int? Salary { get; set; }
        public JobOffer JobOffer { get; set; }
    }
}
