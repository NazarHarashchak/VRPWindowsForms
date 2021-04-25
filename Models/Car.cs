using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPWindowsForms.Models
{
    class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ? CarStatusID { get; set; }
        public CarStatus CarStatus { get; set; }
        public int ? StoreID { get; set; }
        public Store Store { get; set; }

        public List<Order> Orders;
        public Car()
        {
            Orders = new List<Order>();
        }
    }
}
