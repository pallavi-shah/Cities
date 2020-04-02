using System;
using System.Collections.Generic;
using Cities.Comparers;

namespace Cities
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<City> cities = CityDataImporter.LoadData();

            // TODO Swap out comparers as desired

            // 1.To sort the list by CITY
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("** THE LIST ALPHABETICALLY SORTED BY CITY **");
            IComparer<City> comparer = new NameComparer();

            cities.Sort(comparer);

            PrintCities(cities);


            // 2.To sort the list by STATE
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("** THE LIST ALPHABETICALLY SORTED BY STATE **");

            IComparer<City> scomparer = new StateComparer();

            cities.Sort(scomparer);

            PrintCities(cities);


            // 3.To sort the list by POPULATION largest to smallest
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("** THE LIST SORTED BY POPULATION-LARGEST TO SMALLEST **");

            IComparer<City> pcomparer = new PopulationComparer();

            cities.Sort(pcomparer);
            cities.Reverse();
            PrintCities(cities);

            //BONUS MISSION- TO SORT FIRST BY STATE AND THEN BY POPULATION

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("** THE LIST SORTED BY STATE AND THEN BY POPULATION **");
            CompoundComparer ccomparer = new CompoundComparer();
            ccomparer.Comparers.Add(new StateComparer());
            ccomparer.Comparers.Add(new PopulationComparer());
            cities.Sort(ccomparer);
            PrintCities(cities);

            Console.ReadLine();
        }

        private static void PrintCities(List<City> cities)
        {
            Console.WriteLine(City.GetTableHeader());

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
