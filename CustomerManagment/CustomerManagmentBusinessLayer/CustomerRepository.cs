namespace CustomerManagmentBusinessLayer
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerID)
        {
            //Create the instance of the Customer class
            //Pass in the requested ID
            Customer customer = new Customer(customerID);

            //Code for retrieving the defined customer

            //Temporary hard-coded values to return
            //Example of a populated customer
            if (customerID == 1)
            {
                customer.EmailAdrress = "bobosmrad@redtube.com";
                customer.FirstName = "Bobo";
                customer.LastName = "Smard";
            }
            return customer;

        }
        public bool Save(Customer customer)
        {
            //Saves the passed in customer
            return true;
        }
    }
}
