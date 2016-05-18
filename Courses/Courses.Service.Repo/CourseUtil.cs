using System.Configuration;
using System.Data.SqlClient;

namespace Courses.Service.Repo
{
    internal static class CourseUtil
    {
        public static SqlConnection GetDbConnection()
        {
            var conStr = ConfigurationManager.ConnectionStrings["WCF"].ConnectionString;

            return  new SqlConnection(conStr);
        }
    }
}