using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\seleb\Downloads\Pop by Largest Final.csv";
            CsvReader reader = new CsvReader(filePath);

            //List<Country> countries = reader.ReadAllCountries();

            // foreach loop
            /*foreach(Country country in countries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");

            }
            Console.WriteLine($"There are: {countries.Count} countries");*/

            // for loop

            /*Console.Write("Enter number of countries to display: ");
            bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
            if(!inputIsInt || userInput <= 0)
            {
                Console.WriteLine("You must type in a posivet interger. Exiting");
                return;
            }

             int maxToDisplay = userInput;
             for (int i = 0; i < countries.Count; i++)
             {
                 if(i > 0 && (i % maxToDisplay == 0))
                 {
                     Console.WriteLine("Hit ENTER to continue, type no to quit >");
                     if (Console.ReadLine() != "")
                         break;
                 }

                 Country country = countries[i];
                 Console.WriteLine($"{i+1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
             }*/

            //Reverse order
            /*for(int i = countries.Count - 1; i >= 0; i--)
             {
                 int displayIndex = countries.Count - 1 - i;
                 if (displayIndex > 0 && (displayIndex % maxToDisplay == 0))
                 {
                     Console.WriteLine("Hit ENTER to continue, type no to quit >");
                     if (Console.ReadLine() != "")
                         break;
                 }

                 Country country = countries[i];
                 Console.WriteLine($"{displayIndex + 1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
             }*/

            //Removing countries with comma
            /* reader.RemoveCommaCountries(countries);

             Console.Write("Enter number of countries to display: ");
             bool inputIsInt = int.TryParse(Console.ReadLine(), out int userInput);
             if (!inputIsInt || userInput <= 0)
             {
                 Console.WriteLine("You must type in a posivet interger. Exiting");
                 return;
             }

             int maxToDisplay = userInput;
             for (int i = 0; i < countries.Count; i++)
             {
                 if (i > 0 && (i % maxToDisplay == 0))
                 {
                     Console.WriteLine("Hit ENTER to continue, type no to quit >");
                     if (Console.ReadLine() != "")
                         break;
                 }

                 Country country = countries[i];
                 Console.WriteLine($"{i + 1}: {PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
             }*/

            //Alphabetical Order using LINQ
            /*foreach (Country country in countries.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");

            }*/

            //View Countries without comma using LINQ
            /*foreach (Country country in countries.Where(x => !x.Name.Contains(',')).Take(20))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");

            }*/

            //LINQ query syntax
            /*var filteredCountries = countries.Where(x => !x.Name.Contains(',')).Take(20);
            var filteredCountries2 = from country in countries
                                    where !country.Name.Contains(',')
                                    select country;
            foreach(Country country in filteredCountries)
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }*/

            //Display top 10 countries in any region
            /*Dictionary<string, List<Country>> countries = reader.ReadAllCountries();
            foreach (string region in countries.Keys)
                Console.WriteLine(region);

            Console.Write("Which of the above regions do you want? ");
            string chosenRegion = Console.ReadLine();

            if (countries.ContainsKey(chosenRegion))
            {
                foreach (Country country in countries[chosenRegion].Take(10))
                    Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
            }
            else
                Console.WriteLine("That is not a valid region");*/
            //Tic Tec Toe
            Game game = new Game();
            game.PlayGame();
            Console.WriteLine("Game Over");
        }
    }
}
