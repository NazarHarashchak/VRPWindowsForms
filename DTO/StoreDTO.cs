using System;
using System.Collections.Generic;

namespace VRPWindowsForms.DTO
{
    class StoreDTO
    {
        public int ID { get; set; }
        public string StoreName { get; set; }
        public string StoreType { get; set; }
        public string Address { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
