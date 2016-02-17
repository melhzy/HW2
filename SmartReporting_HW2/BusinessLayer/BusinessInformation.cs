using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLayer;
using ModelsLayer;

namespace BusinessLayer
{
    public class BusinessInformation
    {
        public static List<ModelsInformation> GetReportData()
        {
            ModelsInformation IndivDemo = new ModelsInformation();
            var ReportList = new List<ModelsInformation>();
            DataSet dsGetReportData = new DataSet();

            dsGetReportData = DataAccessInformation.GetReportInfo();

            if (dsGetReportData.Tables.Count > 0)
            {
                ReportList = dsGetReportData.Tables[0].AsEnumerable().Select(m => new ModelsInformation
                {
                    ReportID = Convert.ToString(m["ReportID"]),
                    ReportName = Convert.ToString(m["ReportName"]),
                    ReportDesc = Convert.ToString(m["ReportDesc"])

                }).ToList();
            }

            return ReportList;
        }
    }
}
