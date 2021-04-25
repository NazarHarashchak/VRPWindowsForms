using System;
using System.Collections.Generic;

namespace VRPWindowsForms.Models
{
    class Store
    {
        public int ID { get; set; }
        public string StoreName { get; set; }
        public int ? StoreTypeID { get; set; }
        public StoreType StoreType { get; set; }
        public int ? AddressID { get; set; }
        public Address Address { get; set; }
        public List<Car> Cars { get; set; }
        public List<Order> Orders { get; set; }
        public Store()
        {
            Orders = new List<Order>();
            Cars = new List<Car>();
        }
    }
}
