//using CloudIABackend.Models.JobOfferClasses;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CloudIABackend.Models
{
    //[Table("ENUM_JobTechStack")]
    public class ENUM_JobTechStack
    {
        public int Id { get; set; } 
        public string SkillChips { get; set; }

        public ICollection<JobOfferTechStack> ClassJobOffer { get; set; }


        public int CategoryId { get; set; }
        public ENUM_JobTechStackCategory Category { get; set; }


    }
}