using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using L1_TestService.Entities;
using L1_TestService.Util;

namespace L1_TestService
{
    public class MyService: IMyService
    {
        public string GetData()
        {
            return "www.youtube.com";
        }

        public string GetMessage(string Name)
        {
            return "Hello Mr./Ms " + Name;
        }

        public string GetResult(Student s)
        {
            double avg = s.Grades.Average();

            if (avg < 35)
                return "Fail";
            else
                return "Pass";

        }

        public Student GetTopper(List<Student> students)
        {
            return students.OrderByDescending(s => s.Grades.Average()).FirstOrDefault();
        }

        public int GetMax(int[] ar)
        {
            return ar.Max();
        }

        public int[] GetSorted(int[] ar)
        {
            Array.Sort(ar);

            return ar;
        }


        public List<Country> CountriesGetAll()
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