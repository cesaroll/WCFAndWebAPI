using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Courses.Service.Model.Contracts;
using Courses.Service.Model.Util;

namespace Courses.Service.Repo
{
    public class CourseRepo
    {
        /// <summary>
        /// Get All Courses from Db
        /// </summary>
        /// <returns></returns>
        public ReturnMsg ListCourses(out List<Course> courses )
        {
            courses = new List<Course>();
            var retMsg = new ReturnMsg();

            SqlConnection conn = null;
            SqlDataReader dr = null;
            SqlCommand cmd = null;

            try
            {
                conn = CourseUtil.GetDbConnection();

                cmd = new SqlCommand("Select Id, Name, Price from Courses", conn);

                conn.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    courses.Add(new Course()
                    {
                        Id = int.Parse(dr["Id"].ToString()),
                        Name = dr["Name"].ToString(),
                        Price = decimal.Parse(dr["Price"].ToString())
                    });
                }
            }
            catch (Exception e)
            {
                retMsg.Success = false;
                retMsg.Message = "Cannot find Courses!";
                retMsg.ExceptionMsg = e.Message;
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                    dr.Dispose();
                }

                if (cmd != null)
                {
                    cmd.Dispose();
                }

                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }


            return retMsg;

        }
    }
}