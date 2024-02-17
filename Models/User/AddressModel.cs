using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Models.User
{
    [Table("address")]
    public class AddressModel()
    {
        public int Id { get; set; }
        public float Lat { get; set; }
        public float Lon { get; set; }
        public string? State { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address { get; set; }
        public string? Number { get; set; }
        public string? Zipcode { get; set; }
    }
}
