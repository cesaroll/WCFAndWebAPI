using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using Courses.Client.CoursesServiceReference;

namespace Courses.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Service...");

            var svcClient = new CoursesClient();

            List<Course> courses;

            var retMsg = svcClient.ListCourses(out courses);

            Console.Clear();

            if (retMsg.Success)
            {
                Console.WriteLine(" Id  Name         Price");
                Console.WriteLine("---- ------------ --------");

                foreach (var course in courses)
                {
                    Console.WriteLine(" {0}   {1,12} {2:C}", course.Id, course.Name, course.Price);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(retMsg.Message);
                Console.WriteLine();
                Console.WriteLine(retMsg.ExceptionMsg);
                Console.WriteLine();
            }
            

        }
    }
}
