using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10Assignment
{
    internal class AddressBook
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public long zip;
        public long phoneNumber;
        public String email;

        static public void SetAddress()
        {

            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "Balla";
            addressBook.lastName = "Phanindra";
            addressBook.address = "Prashanth Nagar";
            addressBook.city = "MSiddipet";
            addressBook.state = "TS";
            addressBook.zip = 502103;
            addressBook.phoneNumber = 6789009876;
            addressBook.email = "ballaphanindra@gmail.com";
        }
    }
}
