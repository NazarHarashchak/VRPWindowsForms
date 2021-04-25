using System;
using System.Collections.Generic;

namespace VRPWindowsForms.Models
{
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int ? AddressID { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }
        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
