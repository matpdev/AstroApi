using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public struct ResgisterModel(
        string email,
        string password,
        string userName,
        string document,
        string birthDate,
        string description,
        string openingYear,
        string phone,
        string state,
        string city,
        double lat,
        double lon,
        string district,
        string address,
        string number,
        string zipcode,
        string imageIcon,
        string instagramLink,
        string facebookLink,
        string tikTokLink,
        string spotifyLink,
        string websiteLink,
        string youtubeLink,
        string integrationToken,
        string plataform,
        string houseCapacity,
        string gender,
        string documentType
    )
    {
        public string Email { get; set; } = email;
        public string Password { get; set; } = password;
        public string UserName { get; set; } = userName;
        public string Document { get; set; } = document;
        public string BirthDate { get; set; } = birthDate;
        public string Description { get; set; } = description;
        public string OpeningYear { get; set; } = openingYear;
        public string Phone { get; set; } = phone;
        public string State { get; set; } = state;
        public string City { get; set; } = city;
        public double Lat { get; set; } = lat;
        public double Long { get; set; } = lon;
        public string District { get; set; } = district;
        public string Address { get; set; } = address;
        public string Number { get; set; } = number;
        public string ZipCode { get; set; } = zipcode;
        public string ImageIcon { get; set; } = imageIcon;
        public string InstagramLink { get; set; } = instagramLink;
        public string FacebookLink { get; set; } = facebookLink;
        public string TikTokLink { get; set; } = tikTokLink;
        public string SpotifyLink { get; set; } = spotifyLink;
        public string WebsiteLink { get; set; } = websiteLink;
        public string YoutubeLink { get; set; } = youtubeLink;
        public string IntegrationToken { get; set; } = integrationToken;
        public string Plataform { get; set; } = plataform;
        public string HouseCapacity { get; set; } = houseCapacity;
        public string Gender { get; set; } = gender;
        public string DocumentType { get; set; } = documentType;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
