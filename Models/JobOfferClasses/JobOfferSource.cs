namespace CloudIABackend.Models.JobOfferClasses
{
    public class JobOfferSource
    {
        //public int Id { get; set; }
        public string JobGuid { get; set; }
        public ENUM_JobSource JobSource { get; set; }
        public JobOffer JobOffer { get; set; }

        public int SourceId { get; set; }   // this sourceId is Id from table ENUM_JOBSOURCE
        public string SourceUrl { get; set; }   //oto

        public int SourceNumberId { get; set; } // this is ID on source web page, if any.
    }
}
