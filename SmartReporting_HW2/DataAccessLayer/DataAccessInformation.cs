using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccessInformation
    {
        public static DataSet GetReportInfo()
        {

            DataSet dsGetReportInfo = new DataSet();

            dsGetReportInfo.DataSetName = "ReportInfo";

            DataTable dt = new DataTable("ReportList");
            dt.Clear();
            dt.Columns.Add(new DataColumn("ReportID", typeof(string)));
            dt.Columns.Add(new DataColumn("ReportName", typeof(string)));
            dt.Columns.Add(new DataColumn("ReportDesc", typeof(string)));

            DataRow

            dr = dt.NewRow();
            dr["ReportID"] = "Rpt001";
            dr["ReportName"] = "Report One";
            dr["ReportDesc"] = "Report one is blablabla. And report one is another blablabla...";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ReportID"] = "Rpt002";
            dr["ReportName"] = "Report Two";
            dr["ReportDesc"] = "Report two is blablabla. And report two is another blablabla...";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ReportID"] = "Rpt003";
            dr["ReportName"] = "Report Three";
            dr["ReportDesc"] = "Report three is blablabla. And report three is another blablabla...";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ReportID"] = "Rpt004";
            dr["ReportName"] = "Report Four";
            dr["ReportDesc"] = "Report four is blablabla. And report four is another blablabla...";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ReportID"] = "Rpt005";
            dr["ReportName"] = "Report Five";
            dr["ReportDesc"] = "Report five is blablabla. And report five is another blablabla...";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ReportID"] = "Rpt006";
            dr["ReportName"] = "Report Six";
            dr["ReportDesc"] = "Report six is blablabla. And report six is another blablabla...";
            dt.Rows.Add(dr);


            dsGetReportInfo.Tables.Add(dt);

            return dsGetReportInfo;
        }
    }
}
