using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopReportsCapstone
{
    public class Report
    {
        public int ReportID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateLastEdit { get; set; }
        public string Content { get; set; }

    }
}
