using GMap.NET;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPWindowsForms.DTO;
using VRPWindowsForms.Models;
using VRPWindowsForms.Services;

namespace VRPWindowsForms
{
    class VRPService
    {
        private List<CarDTO> cars;
        private DatabaseContext context;
        private List<Order> orders;
        public VRPService() { }
        public VRPService(List<CarDTO> cars)
        {
            this.cars = cars;
            context = new DatabaseContext();
            orders = context.Orders.Include(item => item.Customer).Include(item => item.Car).Include(item => item.OrderStatus).Include(item => item.DeliveryAddress).ToList();
        }
        public List<MapRouteDTO> GetRoutes()
        {
            List<MapRouteDTO> result = new List<MapRouteDTO>();
            foreach (var car in cars)
            {
                var carDB = context.Cars.Where(item => item.ID == car.ID).Include(item => item.Store)
                                   .Include(item => item.Store.Address).FirstOrDefault();
                result.Add(GetRoute(car, carDB));
            }
            return result;
        }
        public MapRouteDTO GetRoute(CarDTO car, Car carDB)
        {
            GoogleMap map = new GoogleMap();
            MapRouteDTO result = new MapRouteDTO();
            result.CarID = car.ID;
            result.StoreID = carDB.Store.ID;

            PointLatLng firstPoint = new PointLatLng(carDB.Store.Address.Lattitude, carDB.Store.Address.Longitude);

            List<MapPoint> finished = new List<MapPoint>();

            List<MapPoint> leftPoints = new List<MapPoint>(car.Orders);

            List<MapPoint> badPoints = new List<MapPoint>();

            int currentID = 0;

            int time = 9 * 60; //start time = 9 AM in minutes
            int stop = 15; //default delay when delivered

            while (leftPoints.Count > 0)
            {
                if (time >= 18 * 60)
                {
                    break;
                }
                var order = leftPoints.First();
                if (result.Route == null || result.Route.Points.Count == 0)
                {
                    result.Route.Points.Add(firstPoint);
                    finished.Add(new MapPoint()
                    {
                        CarID = 0,
                        Lat = firstPoint.Lat,
                        Lng = firstPoint.Lng
                    });
                }

                MapRoute currentRoute = new MapRoute("");

                currentRoute = map.GetRoutes(finished.Last(), order);
                currentID = order.ID;

                double minDistance = currentRoute.Distance;

                MapPoint pointToDelete = order;

                foreach (var point in leftPoints)
                {
                    if (point != order)
                    {
                        MapRoute checkRoute = new MapRoute("");
                        checkRoute = map.GetRoutes(finished.Last(), point);

                        var orderDB = orders.Where(item => item.ID == point.ID).FirstOrDefault();

                        if (orderDB != null)
                        {
                            int beginTimeMin = orderDB.AvailableStartTime.Hours * 60 + orderDB.AvailableStartTime.Minutes;
                            int endTimeMin = orderDB.AvailableEndTime.Hours * 60 + orderDB.AvailableEndTime.Minutes;
                            if (beginTimeMin <= (time + (Convert.ToInt32(checkRoute.Duration) / 60)) 
                                && endTimeMin >= (time + (Convert.ToInt32(checkRoute.Duration) / 60)))
                            {
                                if (minDistance > checkRoute.Distance)
                                {
                                    currentRoute = checkRoute;
                                    currentID = point.ID;
                                    minDistance = checkRoute.Distance;
                                    pointToDelete = point;
                                }  
                            }
                        }
                    }
                }

                time += Convert.ToInt32(Math.Round(Convert.ToDecimal(currentRoute.Duration) / 60, 0));
                time += stop;
                leftPoints.Remove(pointToDelete);
                finished.Add(pointToDelete);
                result.Route.Points.AddRange(currentRoute.Points);
                var orderDBtoAdd = orders.Where(item => item.ID == currentID).FirstOrDefault();
                result.Orders.Add(new OrderDTO() { 
                    ID = orderDBtoAdd.ID,
                    Store = orderDBtoAdd.Store.StoreName,
                    Message = orderDBtoAdd.Message,
                    Weight = orderDBtoAdd.Weight,
                    CustomerFullName = orderDBtoAdd.Customer.Name + " " + orderDBtoAdd.Customer.SecondName,
                    OrderStatus = orderDBtoAdd.OrderStatus.Status,
                    DeliveryAddress = GetAddressService.ToShortAddressWithoutCity(orderDBtoAdd.DeliveryAddress)
                });
            }

            var turnBackToStore = new MapRoute("");
            turnBackToStore = map.GetRoutes(
                new MapPoint() { Lat = result.Route.Points.Last().Lat, Lng = result.Route.Points.Last().Lng },
                new MapPoint() { Lat = firstPoint.Lat, Lng = firstPoint.Lng });
            result.Route.Points.AddRange(turnBackToStore.Points);
            return result;
        }
    }
}
