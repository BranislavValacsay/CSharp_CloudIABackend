using CloudIABackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.DTO
{
    public class JobOfferDto
    {
        public string JobGuid { get; set; }
        public string JobTitle { get; set; }
        public string Language { get; set; }
        public string State { get; set; }
        public bool JobClosed { get; set; }
        public string JobUrl { get; set; }
        public int Salary { get; set; }
        public string JobType { get; set; }
        public string Tasks { get; set; }
        public ICollection<ENUM_JobTechStacKDTO> TechStack { get; set; }
        public string PrimarySkill { get; set; }
        public string SecondarySkill { get; set; }
    }
}
