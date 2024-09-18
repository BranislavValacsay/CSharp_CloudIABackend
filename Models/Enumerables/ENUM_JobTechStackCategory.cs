
using System.Collections.Generic;

namespace CloudIABackend.Models
{
    public class ENUM_JobTechStackCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<ENUM_JobTechStack> skillChips { get; set; }
    }
}