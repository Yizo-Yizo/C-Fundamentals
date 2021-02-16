using ACM.BL;
using System;

namespace ACMexecutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Address address = new Address();
            CustomerRepository customerRepo = new CustomerRepository();
            AddressRepository addressRepo = new AddressRepository();

            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            customer.FirstName = firstName;

            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            customer.LastName = lastName;

           Console.WriteLine("\nEnter your address \n");
            Console.WriteLine("Enter house number and street name: ");
            string streetName = Console.ReadLine();
            address.StreetLine1 = streetName;

            Console.WriteLine("Enter suburb: ");
            string suburb = Console.ReadLine();
            address.StreetLine2 = suburb;

            Console.WriteLine("Enter City: ");
            string city = Console.ReadLine();
            address.City = city;

            Console.WriteLine("Enter pronvince or state: ");
            string state = Console.ReadLine();
            address.State = state;

            Console.WriteLine("Enter Country: ");
            string country = Console.ReadLine();
            address.Country = country;

            // Save information
            customerRepo.Save(customer);
            addressRepo.Save(address);
            // Retrieve information
            customerRepo.Retrieve(Customer.InstaceCount);
        }
    }
}
