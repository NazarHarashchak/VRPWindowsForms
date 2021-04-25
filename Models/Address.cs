using System;
using System.Collections.Generic;

namespace VRPWindowsForms.Models
{
    class Address
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public bool IsPrivateHouse { get; set; }
        public int AppartmentsNumber { get; set; }
        public string PostCode { get; set; }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
    }
}
