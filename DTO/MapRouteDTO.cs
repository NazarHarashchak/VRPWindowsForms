using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRPWindowsForms.DTO
{
    class MapRouteDTO
    {
        public int StoreID { get; set; }
        public int CarID { get; set; }
        public List<OrderDTO> Orders { get; set; }
        public MapRoute Route { get; set; }
        public MapRouteDTO()
        {
            Orders = new List<OrderDTO>();
            Route = new MapRoute("");
        }
    }
}
