using System.Collections.Generic;
using System.Data.SqlClient;
using DataLib.Util;
using ModelLib.Query;

namespace DataLib.Factory
{
    public class CountryFactory: Factory, ICountryFactory
    {
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
    }
}