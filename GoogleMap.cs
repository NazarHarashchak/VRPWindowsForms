using GMap.NET;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using VRPWindowsForms.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VRPWindowsForms
{
    class GoogleMap
    {
        private readonly string API_KEY = "AIzaSyBAYXQlJbw-pkM6X0wacvJqDqUIukxio24";
        private readonly string format = "json";
        public GoogleMap() { }
        public GoogleMap(string format)
        {
            this.format = format;
        }
        public MapRoute GetRoutes(MapPoint start, MapPoint end)
        {
            string startPoint = String.Format("origin={0},{1}", start.Lat.ToString().Replace(',', '.'), start.Lng.ToString().Replace(',', '.'));
            string endPoint = String.Format("destination={0},{1}", end.Lat.ToString().Replace(',', '.'), end.Lng.ToString().Replace(',', '.'));
            string key = String.Format("key={0}", API_KEY);
            string path = String.Format(@"https://maps.googleapis.com/maps/api/directions/{0}?{1}&{2}&{3}",
                format,
                startPoint,
                endPoint,
                key);

            string content = null;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (content == null)
                return null;
            MapRoute result = new MapRoute("My way");

            JObject jObject = JObject.Parse(content);
            var route = jObject["routes"][0]["legs"][0];
            result.Duration = route["duration"]["value"].ToString();
            result.Points.Add(new PointLatLng()
            {
                Lat = Convert.ToDouble(route["start_location"]["lat"].ToString()),
                Lng = Convert.ToDouble(route["start_location"]["lng"].ToString())
            });
            foreach (var step in route["steps"].Children())
            {
                result.Points.Add(new PointLatLng() 
                { 
                    Lat = Convert.ToDouble(step["end_location"]["lat"].ToString()),
                    Lng = Convert.ToDouble(step["end_location"]["lng"].ToString())
                });
            }

            return result;
        }

        public PointLatLng GetCoordinates(string country, string city, string street, string houseNumber)
        {
            PointLatLng result = new PointLatLng();
            string divider = "%20";

            string key = String.Format("key={0}", API_KEY);
            string place = String.Format("address={0}{1}{2}{3}{4}{5}{6}",
                                        country, divider, city, divider, street, divider, houseNumber);
            string path = String.Format(@"https://maps.googleapis.com/maps/api/geocode/{0}?{1}&{2}",
                format,
                place,
                key);

            string content = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                content = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (content == null)
            {
                return result;
            }

            JObject jObject = JObject.Parse(content);
            var route = jObject["results"][0]["geometry"]["location"];

            result = new PointLatLng() 
            { 
                Lat = Convert.ToDouble(route["lat"].ToString()),
                Lng = Convert.ToDouble(route["lng"].ToString())
            };

            return result;
        }
    }
}
