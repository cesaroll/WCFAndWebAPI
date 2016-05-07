using System;
using System.Collections.Generic;
using System.Linq;
using L1_TestService.Entities;

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
    }
}