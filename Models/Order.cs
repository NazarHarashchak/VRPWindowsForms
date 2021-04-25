using System;
using System.Collections.Generic;

namespace VRPWindowsForms.Models
{
    class Order
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan AvailableStartTime { get; set; }
        public TimeSpan AvailableEndTime { get; set; }
        public string Message { get; set; }
        public int ? OrderStatusID { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int ? CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int ? AddressID { get; set; }
        public Address DeliveryAddress { get; set; }
        public int ? StoreID { get; set; }
        public Store Store { get; set; }
        public int ? CarID { get; set; }
        public Car Car { get; set; }
    }
}
