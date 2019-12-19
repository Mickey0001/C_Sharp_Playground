using Customer.Common;
using System;
using System.Collections.Generic;

namespace CustomerManagmentBusinessLayer
{
    public class Order : EntityBase, ILoggable 
    {
        public Order() : this(0)
        {

        }

        public Order(int orderID)
        {
            OrderID = orderID;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerID { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderID { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public int ShippingAddressID { get; set; }

        public string Log() => $"{OrderID}: Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";

        public string log()
        {
            throw new NotImplementedException();
        }

        public override string ToString() => $"{OrderDate.Value.Date}({OrderID})";

        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
