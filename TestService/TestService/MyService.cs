using System;
using System.Collections.Generic;
using System.Linq;
using DataLib.Factory;
using ModelLib.Query;

namespace TestService
{
    public class MyService : IMyService
    {
        /*
        private ICountryFactory CountryFactory { get; set; }

        public MyService()
            : this(DependencyFactory.Resolve<ICountryFactory>())
        {
        }


        public MyService(ICountryFactory countryFactory)
        {
            CountryFactory = countryFactory;
        }
        */


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
            ICountryFactory countryFact = DependencyFactory.Resolve<ICountryFactory>();

            return countryFact.GetAll();
        }

        #region Method overloading
        public int Multiply(int a, int b)
        {
            return a*b;
        }

        public double Multiply(double a, double b)
        {
            return a*b;
        }

        #endregion
    }
}