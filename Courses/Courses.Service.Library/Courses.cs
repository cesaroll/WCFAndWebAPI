using System.Collections.Generic;
using Courses.Service.Model.Contracts;
using Courses.Service.Model.Util;
using Courses.Service.Repo;

namespace Courses.Service.Library
{
    public class Courses : ICourses
    {

        public void AddToCourses(Course course)
        {
            //courses.Add(course);
        }

        public ReturnMsg ListCourses(out List<Course> Courses)
        {
            var rep = new CourseRepo();

            var retMsg = rep.ListCourses(out Courses);

            return retMsg;     
        }

       
    }
}