using System.Configuration;
using System.Data.SqlClient;

namespace DataLib.Util
{
    internal class DbUtil
    {
        public static SqlConnection WCFGetConnection()
        {
            var conStr = ConfigurationManager.ConnectionStrings["WCF"].ConnectionString;

            return new SqlConnection(conStr);
        } 
    }
}