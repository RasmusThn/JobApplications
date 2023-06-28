using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys
{
    public class Job
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string JobType { get; set; }
        public string Location { get; set; }
        public DateTime ApplyDate { get; set; }
        public DateTime ResponseDate { get; set; }
        public bool IsAccepted { get; set; } = false;
        public string UserName { get; set; }

        
    }
}
