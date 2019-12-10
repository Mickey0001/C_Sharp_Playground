using System.Collections.Generic;

namespace CustomerManagmentBusinessLayer
{
    public class AddressRepository
    {
        public Address Retrieve(int addressID)
        {
            Address address = new Address(addressID);

            if (addressID == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Focacka 69";
                address.StreetLine2 = "Sarajevska 666";
                address.City = "Rogatica";
                address.State = "Kanton Sarajevski";
                address.PostalCode = "71000";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerID(int customerID)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Focacka 96",
                StreetLine2 = "Sarajevska 555",
                City = "Gorazde",
                State = "Kanton Sarajevski",
                PostalCode = "144"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Focacka 44",
                StreetLine2 = "Sarajevska 333",
                City = "Ustikolina",
                State = "Kanton Sarajevski",
                PostalCode = "6666666"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
