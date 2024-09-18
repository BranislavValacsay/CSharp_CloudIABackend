using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudIABackend.Helpers
{
    public class FilterParams
    {
        public string title { get; set; }
        public string techStack { get; set; }
        public string language { get; set; }
        public bool jobClosed { get; set; }
        public string jobType { get; set; }
    }
}
