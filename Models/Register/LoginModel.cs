using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AstroApi.Models
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public struct LoginModel(string email, string password)
    {
        public string Email { get; set; } = email;
        public string Password { get; set; } = password;

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
