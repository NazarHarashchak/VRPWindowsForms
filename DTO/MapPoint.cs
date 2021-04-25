using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPWindowsForms.Models;

namespace VRPWindowsForms.DTO
{
    class MapPoint
    {
        public int ID { get; set; }
        public string StreetName { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int CarID { get; set; }
        public string CarName { get; set; }
    }
}
