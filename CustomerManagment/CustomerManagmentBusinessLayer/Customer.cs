using System.Collections.Generic;

namespace CustomerManagmentBusinessLayer
{
    public class Customer
    {
        public Customer()
        {

        }

        public Customer(int customerID)
        {
            CustomerID = customerID;
        }

        public int CustomerID { get; private set; }
        public string EmailAdrress { get; set; }
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public string LastName
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }
        }
        public static int InstanceCount { get; set; }

        public Customer Retrieve(int customerID)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdrress)) isValid = false;

            return isValid;
        }
    }
}
