using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRPWindowsForms.Models;

namespace VRPWindowsForms.Services
{
    static class GetAddressService
    {
        public static Address GetNewAddress(GoogleMap gMap, string country, string city, string street, string houseNumber, bool isPrivateHouse, int appartmentsNumber, string postCode)
        {
            Address result = new Address();

            result.Country = country;
            result.City = city;
            result.Street = street;
            result.HouseNumber = houseNumber;
            result.IsPrivateHouse = isPrivateHouse;
            result.AppartmentsNumber = appartmentsNumber;
            result.PostCode = postCode;

            PointLatLng point = new PointLatLng();
            point = gMap.GetCoordinates("Ukraine", result.City, result.Street, result.HouseNumber);

            if (!point.IsEmpty)
            {
                result.Lattitude = point.Lat;
                result.Longitude = point.Lng;
            }

            return result;
        }

        public static string ToShortAddress(Address address)
        {
            return string.Format("{0}, {1} {2}, {3}", address.City, address.Street, address.HouseNumber, address.AppartmentsNumber);
        }

        public static string ToShortAddressWithoutCity(Address address)
        {
            return string.Format("{0} {1}, {2}", address.Street, address.HouseNumber, address.AppartmentsNumber);
        }
    }
}
