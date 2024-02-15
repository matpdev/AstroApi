using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Models.User
{
    public class AddressModel(
        int id,
        float lat,
        float lon,
        string state,
        string city,
        string district,
        string address,
        string number,
        string zipcode
    )
    {
        public int id = id;
        public float lat = lat;
        public float lon = lon;
        public string? state = state;
        public string? city = city;
        public string? district = district;
        public string? address = address;
        public string? number = number;
        public string? zipcode = zipcode;

        public static AddressModel fromMap(Dictionary<string, dynamic> map)
        {
            return new AddressModel(
                id: map["id"],
                lat: map["lat"],
                lon: map["long"],
                state: map["state"],
                city: map["state"],
                district: map["district"],
                address: map["address"],
                number: map["number"],
                zipcode: map["zipcode"]
            );
        }
    }
}
