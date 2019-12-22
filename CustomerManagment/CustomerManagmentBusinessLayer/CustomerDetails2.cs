using System.Collections.Generic;
using Customer.Common;

namespace CustomerManagmentBusinessLayer
{
    public class CustomerDetails2 : EntityBase, ILoggable
    {
        public CustomerDetails2(): this(0)
        {

        }

        public CustomerDetails2(int customerID)
        {
            CustomerID = customerID;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set;  }
        public int CustomerID { get; private set; }
        public int CustomerType { get; set; }
        public string EmailAdrress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public static int InstanceCount { get; set; }

        public string Log() => $"{CustomerID}: {FullName} Email: {EmailAdrress} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdrress)) isValid = false;

            return isValid;
        }

#pragma warning disable CS0539 // 'CustomerDetails2.log()' in explicit interface declaration is not found among members of the interface that can be implemented
        string ILoggable.log()
#pragma warning restore CS0539 // 'CustomerDetails2.log()' in explicit interface declaration is not found among members of the interface that can be implemented
        {
            throw new System.NotImplementedException();
        }
    }
}
