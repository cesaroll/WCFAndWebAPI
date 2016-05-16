﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MyClientConsole.MulServiceReference;
using MyClientConsole.Util;

namespace MyClientConsole
{
    class Program
    {
        protected virtual void SaveCountry()
        {
            Console.Clear();
            Console.WriteLine("Calling web Service...");
            
            var srvClient = ServiceFactory.GetMainService();

            var country = new MySrvRefOnIIS.Country() 
            {
                Id = 1, 
                Name = "Mexico"
            };

            var ret = srvClient.CountrySave(country);
           

            if (ret.Success)
            {
                Console.WriteLine("Success!");
                Console.WriteLine(ret.Message);
            }
            else
            {
                Console.WriteLine("Erro:");
                Console.WriteLine(ret.Message + "\n");
                Console.WriteLine(ret.ex.Message);
            }

            Console.ReadKey(true);

        }
        protected virtual void MultiplicationOverloaded()
        {
            Console.Clear();
            Console.WriteLine("Calling WebService...");
            var serviceClient = ServiceFactory.GetMainService();

            int first = serviceClient.MultiplyInt(5, 5);
            double second = serviceClient.MultiplyDouble(5.5, 5.5);

            Console.Clear();

            Console.WriteLine("  5 x 5   = {0}", first);
            Console.WriteLine("5.5 x 5.5 = {0}", second);

            Console.ReadKey(true);

        }

        protected virtual void DisplayAllCountriesFromIIS()
        {
            Console.Clear();
            Console.WriteLine("Calling WebService...");

            var client = new MySrvRefOnIIS.CountriesServiceClient();


            string data = client.GetData();

            Console.Clear();
            Console.WriteLine(data);
            Console.WriteLine();

            
            var countries = client.CountriesGetAll();

            
            Console.WriteLine("Countries:");
            Console.WriteLine("========  =======================================");
            Console.WriteLine("   ID     Name");
            Console.WriteLine("========  =======================================");


            foreach (var country in countries)
            {
                Console.WriteLine("   {0,2}     {1}", country.Id, country.Name);
            }
            
            Console.ReadKey(true);
        }

        protected virtual void Multiplication()
        {
            var client = new MulServiceClient("BasicHttpBinding_IMulService");

            int total, a, b;

            Console.Clear();
            Console.WriteLine("Type first value: ");
            int.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Type second value: ");
            int.TryParse(Console.ReadLine(), out b);

            total = client.Multiply(a, b);

            Console.WriteLine("{0} times {1} equals: {2} ", a, b, total);

            Console.ReadKey(true);

        }

        protected virtual void DisplayAllCountries()
        {
            Console.Clear();
            Console.WriteLine("Calling WebService...");

            var client = new MyServiceReference.CountriesServiceClient();

            var countries = client.CountriesGetAll();

            Console.Clear();
            Console.WriteLine("Countries:");
            Console.WriteLine("========  =======================================");
            Console.WriteLine("   ID     Name");
            Console.WriteLine("========  =======================================");
            

            foreach (var country in countries)
            {
                Console.WriteLine("   {0,2}     {1}", country.Id, country.Name);
            }

            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            var prog = new Program();

            prog.Menu();
        }

        protected virtual void Menu()
        {
            char value = ' ';

            while (value != '.')
            {
                DisplayMenu();

                value = char.ToUpper(Console.ReadKey(true).KeyChar);

                Console.Clear();

                switch (value)
                {
                    case 'A':
                        DisplayAllCountries();
                        break;
                    case 'B':
                        Multiplication();
                        break;
                    case 'C':
                        DisplayAllCountriesFromIIS();
                        break;
                    case 'D':
                        MultiplicationOverloaded();
                        break;
                    case 'E':
                        SaveCountry();
                        break;
                }


            }
            


        }

        protected virtual void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("A) Display All Countries");
            Console.WriteLine("B) Multiplication");
            Console.WriteLine("C) Display All Countries from IIS");
            Console.WriteLine("D) Multiplication using Overloading");
            Console.WriteLine("E) Save Country");

            Console.WriteLine();
            Console.WriteLine("Type a letter or '.' to leave.");
        }
    }
}
