using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataLib.Util;
using ModelLib.Query;
using ModelLib.Util;

namespace DataLib.Factory
{
    public class CountryFactory: Factory, ICountryFactory
    {
        /// <summary>
        /// Get All countries
        /// </summary>
        /// <returns></returns>
        public List<Country> GetAll()
        {
            var countries = new List<Country>();

            using (var conn = DbUtil.WCFGetConnection())
            {
                var cmd = new SqlCommand("Select Id, Name From Countries", conn);

                conn.Open();

                var dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    countries.Add(new Country()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        Name = dr["Name"].ToString()
                    });
                }

                dr.Close();
                conn.Close();
            }

            return countries;
        }

        /// <summary>
        /// Save Country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public IReturnMsg Save(Country country)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;

            var retMsg = DependencyFactory.Resolve<IReturnMsg>();

            string queryStr = @"Merge Countries as t
Using (Values(@Id, @Name)) as v (Id, Name)
  On t.id = v.Id
When Matched Then
	Update Set t.Name = v.Name
When Not Matched Then
	Insert (Id, Name)
	Values(v.Id, v.Name);";

            try
            {
                conn = DbUtil.WCFGetConnection();

                cmd = new SqlCommand(queryStr, conn);
                
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = country.Id;
                cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = country.Name;
                
                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    retMsg.Success = true;
                    retMsg.Message = "Country Saved";
                }
            }
            catch (Exception e)
            {
                retMsg.Success = false;
                retMsg.Message = "Country was not saved.";
                retMsg.ex = e;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }

                if (cmd != null)
                    cmd.Dispose();
                
            }

            return retMsg;

        }
    }
}