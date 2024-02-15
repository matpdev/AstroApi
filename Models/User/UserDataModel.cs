using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Models.User
{
    public class UserDataModel(
        int id,
        string birthDate,
        string description,
        string openingYear,
        string imageIcon,
        string gender,
        int houseCapacity,
        List<AddressModel>? addresses
    )
    {
        public int id;
        public string? birthDate;
        public string? description;
        public string? openingYear;
        public string? imageIcon;
        public string? gender;
        public int? houseCapacity;

        public List<AddressModel>? addresses = [];
        public UserModel userModel;

        public static UserDataModel fromMap(Dictionary<string, dynamic> map)
        {
            return new UserDataModel(
                id: map["id"],
                birthDate: map["birth_date"],
                description: map["description"],
                openingYear: map["opening_year"],
                imageIcon: map["image_icon"],
                gender: map["gender"],
                houseCapacity: map["house_capacity"],
                addresses: (List<AddressModel>)
                    (map["addresses"] as List<Dictionary<string, dynamic>>).Select(t =>
                        AddressModel.fromMap(t)
                    )
            );
        }
    }
}
