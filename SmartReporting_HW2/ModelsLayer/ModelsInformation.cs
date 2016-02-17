using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ModelsLayer
{
    public class ModelsInformation
    {

        [DisplayName("ReportID")]
        public string ReportID { get; set; }

        [DisplayName("ReportName")]
        public string ReportName { get; set; }

        [DisplayName("ReportDesc")]
        public string ReportDesc { get; set; }

    }
}
