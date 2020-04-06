using System;
using System.Collections.Generic;
using Dapper;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopReportsCapstone
{
    //This DataAccess Class provides a layer of separation between the Dashboard Form logic and the Azure Database. 
    //These DataAccess Methods connect to the database using params in Stored Procedures, instead of building
    //Transact SQL statements directly in the App.
    class DataAccess
    {
        public List<Report> GetReports()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ReportsProjectDb")))
            {
                return connection.Query<Report>("dbo.spReport_GetAllReverseChron").ToList();
            }
        }

        public void UpdateReport(Report report)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ReportsProjectDb")))
            {
                connection.Execute("dbo.spReport_UpdateReport @ReportID, @DateLastEdit, @Content", report);
            }
        }

        public void InsertReport(Report report)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("ReportsProjectDb")))
            {
                connection.Execute("dbo.spReport_InsertReport @DateCreated, @Content", report);
            }
        }
    }
}
