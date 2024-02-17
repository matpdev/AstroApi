using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Models.User
{
    [Table("user_data")]
    public class UserDataModel()
    {
        [Key]
        public int Id { get; protected set; }
        public string? BirthDate { get; set; }
        public string? Description { get; set; }
        public string? OpeningYear { get; set; }
        public string? ImageIcon { get; set; }
        public string? Gender { get; set; }
        public int? HouseCapacity { get; set; }

        public List<AddressModel>? Addresses { get; set; }
    }
}
