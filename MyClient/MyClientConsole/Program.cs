using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClientConsole.MyServiceReference;

namespace MyClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();

            prog.Menu();
        }

        private void DisplayAllCountries()
        {
            var client = new MyServiceClient();

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

        private void Menu()
        {
            char value = ' ';

            while (value != '.')
            {
                DisplayMenu();

                value = char.ToUpper(Console.ReadKey(true).KeyChar);

                switch (value)
                {
                    case 'A':
                        DisplayAllCountries();
                        break;
                }


            }
            


        }

        private void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("A) Display All Countries");

            Console.WriteLine();
            Console.WriteLine("Type a letter or '.' to leave.");
        }
    }
}
