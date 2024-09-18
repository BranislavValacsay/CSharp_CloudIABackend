using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.DTO
{
    public class AUTH_JobOfferDto
    {
        public string JobTitle { get; set; }
        public string Language { get; set; }
        public string State { get; set; }
        public bool JobClosed { get; set; }
        public string JobUrl { get; set; }
        public string Source { get; set; }
        public string SourceUrl { get; set; }
        public string JobType { get; set; }
        public int SourceID { get; set; }
        public ICollection<ENUM_JobTechStacKDTO> TechStack { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set; }

    }
}
