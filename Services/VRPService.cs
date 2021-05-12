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
        public List<MapRouteDTO> GetRoutes()
        {
            List<MapRouteDTO> result = new List<MapRouteDTO>();
            foreach (var car in cars)
            {
                var carDB = context.Cars.Where(item => item.ID == car.ID).Include(item => item.Store)
                                   .Include(item => item.Store.Address).FirstOrDefault();
                result.Add(new MapRouteDTO() 
                { 
                    CarID = car.ID,
                    StoreID = carDB.Store.ID,
                    Route = this.GetRoute(car, carDB) 
                });
            }
            return result;
        }
        public MapRoute GetRoute(CarDTO car, Car carDB)
        {
            GoogleMap map = new GoogleMap();
            MapRoute result = new MapRoute(car.CarName);

            PointLatLng firstPoint = new PointLatLng(carDB.Store.Address.Lattitude, carDB.Store.Address.Longitude);

            List<MapPoint> finished = new List<MapPoint>();

            List<MapPoint> leftPoints = new List<MapPoint>(car.Orders);

            while (leftPoints.Count > 0)
            {
                var order = leftPoints.First();
                if (result.Points.Count == 0)
                {
                    result.Points.Add(firstPoint);
                    finished.Add(new MapPoint()
                    {
                        CarID = 0,
                        Lat = firstPoint.Lat,
                        Lng = firstPoint.Lng
                    });
                }
                MapRoute currentRoute = new MapRoute("");

                currentRoute = map.GetRoutes(finished.Last(), order);

                double minDistance = currentRoute.Distance;

                MapPoint pointToDelete = order;

                foreach (var point in leftPoints)
                {
                    if (point != order)
                    {
                        MapRoute checkRoute = new MapRoute("");
                        checkRoute = map.GetRoutes(finished.Last(), point);
                        if (minDistance > checkRoute.Distance)
                        {
                            currentRoute = checkRoute;
                            minDistance = checkRoute.Distance;
                            pointToDelete = point;
                        }
                    }
                }

                leftPoints.Remove(pointToDelete);
                finished.Add(pointToDelete);
                result.Points.AddRange(currentRoute.Points);
            }

            var turnBackToStore = new MapRoute("");
            turnBackToStore = map.GetRoutes(
                new MapPoint() { Lat = result.Points.Last().Lat, Lng = result.Points.Last().Lng },
                new MapPoint() { Lat = firstPoint.Lat, Lng = firstPoint.Lng });
            result.Points.AddRange(turnBackToStore.Points);
            return result;
        }
    }
}
