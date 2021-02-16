using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string filePath = @"C:\Users\seleb\Downloads\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> countries = reader.ReadAllCountries();
            Country capeTown = new Country("Cape Town", "CPT", "Africa", 2000000);
            int capeTownIndex = countries.FindIndex(x => x.Population < 2000000);
            countries.Insert(capeTownIndex, capeTown); // This is not ideal for a largest list 
            //countries.RemoveAt(capeTownIndex);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15): country.Population}: {country.Name}");
            }

            Console.WriteLine($"There are {countries.Count} countries");

        }
    }
}
