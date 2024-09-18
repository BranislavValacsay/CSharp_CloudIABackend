using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Models
{
    public class CandidateApplications
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string Url { get; set; }
        public string visitDate { get; set; }
        public string visitTime { get; set; }
    }
}
