using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Models
{
    public class Visitors
    {
        public int Id { get; set; }
        public int JobOfferId { get; set; }
        public string VisitorIp { get; set; }
        public string JobUrl { get; set; }
        public string visitDate { get; set; }
        public string visitTime { get; set; }
    }
}
