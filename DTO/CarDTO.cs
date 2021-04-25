using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPWindowsForms.DTO
{
    class CarDTO
    {
        public int ID { get; set; }
        public string CarName { get; set; }
        public string StoreName { get; set; }
        public string CarStatus { get; set; }
        public List<MapPoint> Orders { get; set; }
        public CarDTO()
        {
            Orders = new List<MapPoint>();
        }
    }
}
