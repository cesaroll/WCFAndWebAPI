using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using DataLib.Factory;
using ModelLib.Query;
using ModelLib.Util;
using TestService.Util;

namespace TestService
{
    public class MyService : IMyService
    {
        #region Resolving Dependency injection at Constructor level
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
        #endregion

        #region Basic Methods
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
        #endregion

        #region Country
        public List<Country> CountriesGetAll()
        {
            ICountryFactory countryFact = DependencyFactory.Resolve<ICountryFactory>();

            return countryFact.GetAll();
        }

        public ReturnMsg CountrySave(Country country)
        {
            var fact = DependencyFactory.Resolve<ICountryFactory>();

            return fact.Save(country) as ReturnMsg;

        }

        #endregion

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