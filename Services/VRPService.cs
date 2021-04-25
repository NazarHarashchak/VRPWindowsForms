using GMap.NET;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPWindowsForms.DTO;
using VRPWindowsForms.Models;

namespace VRPWindowsForms
{
    class VRPService
    {
        private List<CarDTO> cars;
        private DatabaseContext context;
        public VRPService() { }
        public VRPService(List<CarDTO> cars)
        {
            this.cars = cars;
            context = new DatabaseContext();
        }
        public List<MapRoute> GetRoutes()
        {
            List<MapRoute> result = new List<MapRoute>();
            foreach(var car in cars)
            {
                result.Add(this.GetRoute(car));
            }
            return result;
        }
        public MapRoute GetRoute(CarDTO car)
        {
            MapRoute result = new MapRoute(car.CarName);
            var carDB = context.Cars.Where(item => item.ID == car.ID).Include(item => item.Store)
                                    .Include(item => item.Store.Address).FirstOrDefault();
            PointLatLng firstPoint = new PointLatLng(carDB.Store.Address.Lattitude, carDB.Store.Address.Longitude);
            result.Points.Add(firstPoint);

            List<MapPoint> allPoints = new List<MapPoint>(car.Orders);
            return result;
        }
    }
}
