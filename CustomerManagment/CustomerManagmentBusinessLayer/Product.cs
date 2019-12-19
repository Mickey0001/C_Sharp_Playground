using Customer.Common;

namespace CustomerManagmentBusinessLayer
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productID)
        {
            ProductID = productID;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductID { get; private set; }

        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set
            {
                _productName = value; 
            }
        }

        public override string ToString() => ProductName;

        public string Log() => $"{ProductID}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public string log()
        {
            throw new System.NotImplementedException();
        }
    }


}
