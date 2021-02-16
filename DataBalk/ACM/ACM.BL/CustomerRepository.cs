using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        string connectionString = "server=localhost;user id=root;password=Thapelo26%;database=Business";

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            // Code that retrieves the difined customer.
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            MySqlCommand command = con.CreateCommand();

            command.Parameters.AddWithValue("@id", customerId);
            command.CommandText = "SELECT * FROM customer WHERE id = @id";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
                Console.WriteLine(reader.GetString(2));
            }
            return customer;
        }

        // Saves the current customer.
        public bool Save(Customer customer)
        {
            string Query = "INSERT INTO customer(firstName, lastName) VALUES ('" + customer.FirstName + "','" + customer.LastName + "');";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            con.Open();
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            MySqlCommand command = con.CreateCommand();
            con.Close();
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
               
                    if (customer.IsNew)
                    {
                        // Call an Insert Stored Procedure
                        
                    }
                    else
                    {
                        // Call an Update Stored Procedure
                        
                    }
                }
                else
                {
                    success = false;
                }
            return success;
        }
    }
}
