using System.Collections.Generic;
using System.ServiceModel;
using Courses.Service.Model.Contracts;
using Courses.Service.Model.Util;

namespace Courses.Service.Library
{
    [ServiceContract]
    public interface ICourses
    {
        [OperationContract]
        void AddToCourses(Course course);

        [OperationContract]
        ReturnMsg ListCourses(out List<Course> Courses);
    }
}