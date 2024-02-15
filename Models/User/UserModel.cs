using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Models.User
{
    public class UserModel
    {
        public int id;
        public string document;
        public string documentType;
        public string strapiId;
        public int userDataId;
        public int userLoginId;

        public UserDataModel userData;
    }
}
