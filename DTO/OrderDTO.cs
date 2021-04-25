using System;
using System.Collections.Generic;

namespace VRPWindowsForms.DTO
{
    class OrderDTO
    {
        public int ID { get; set; }
        public double Weight { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan AvailableStartTime { get; set; }
        public TimeSpan AvailableEndTime { get; set; }
        public string Message { get; set; }
        public string OrderStatus { get; set; }
        public string CustomerFullName { get; set; }
        public string DeliveryAddress { get; set; }
        public string Store { get; set; }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
    }
}
