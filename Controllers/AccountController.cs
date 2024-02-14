using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstroApi.Models;
using AstroApi.Utils.Extends;
using Microsoft.AspNetCore.Mvc;

namespace AstroApi.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        private DbControllers.DbController controller = new DbControllers.DbController();

        [Route("/account/login")]
        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginModel? ites)
        {
            await controller.LoginUser(ites.Value.Email, ites.Value.Password);
            return Ok($"Request Body As String: {ites}");
        }

        [Route("/account/register")]
        [HttpPost]
        public async Task<IActionResult> RegisterUser(ResgisterModel? ites)
        {
            return Ok($"Request Body As String: {ites}");
        }

        bool VerifyUserExistent(string email)
        {
            return false;
        }
    }
}
