using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Program2
    {
        public static void Main(string[] args)
        {
           
            string filePath = @"C:\Users\seleb\Downloads\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach (Country country in countries)
            {
                Console.WriteLine($"{PopulationFomatter.FormatPopulation(country.Population).PadLeft(15): country.Population}: {country.Name}");
            } 
        }
    }
}
