using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AstroApi.Models.User
{
    [Table("user")]
    public class UserModel
    {
        [Key]
        public int Id { get; protected set; }
        public string Document { get; set; }
        public string DocumentType { get; set; }
        public string StrapiId { get; set; }
        public int UserDataId { get; set; }
        public int UserLoginId { get; set; }

        public virtual ICollection<UserDataModel> UserData { get; set; }

        public string ToStringData()
        {
            return $"id: {Id}, Document: {Document}, DocumentType: {DocumentType}, StrapiId: {StrapiId}";
        }
    }
}
