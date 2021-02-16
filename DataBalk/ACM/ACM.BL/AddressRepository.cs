using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        string connectionString = "server=localhost;user id=root;password=Thapelo26%;database=Business";

        // Retrieve one address.
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            // Code that retrieves the defined address

            // Temporary hard coded values to return
            // a populated address
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Hobbiton";
                address.State = "Shire";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.

            //Temporary hard-coded values to return
            // a set of addresses for a customer
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                City = "Hobbiton",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                State = "Shire",
                Country = "Middle Eart",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;
        }

        // Save the current address.
        public bool Save(Address address)
        {
            string Query = "INSERT INTO address(streetLine1, streetLine2, city, state, country) VALUES ('" + address.StreetLine1 + "','" + address.StreetLine2 + "','" + address.City + "','" + address.State + "','" + address.Country + "');";
            MySqlConnection con = new MySqlConnection(connectionString);
            MySqlCommand MyCommand = new MySqlCommand(Query, con);
            con.Open();
            MySqlDataReader MyReader = MyCommand.ExecuteReader();
            MySqlCommand command = con.CreateCommand();
            con.Close();
            var success = true;
            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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
            }

            return true;
        }
    }
}
