using System.Linq;

namespace CustomerManagmentBusinessLayer
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }

        public CustomerDetails2 Retrieve(int customerID)
        {
            //Create the instance of the Customer class
            //Pass in the requested ID
            CustomerDetails2 customer = new CustomerDetails2(customerID);

            //Code for retrieving the defined customer

            //Temporary hard-coded values to return
            //Example of a populated customer
            if (customerID == 1)
            {
                customer.EmailAdrress = "bobosmard@xvideos.com";
                customer.FirstName = "Bobo ";
                customer.LastName = "Smrad";
                customer.AddressList = addressRepository.RetrieveByCustomerID(customerID).ToList();
            }
            return customer;

        }
        public bool Save(CustomerDetails2 customer)
        {
            //Saves the passed in customer
            return true;
        }
    }
}
