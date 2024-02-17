using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AstroApi.DbControllers;
using AstroApi.Models;
using AstroApi.Utils.Extends;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AstroApi.Controllers
{
    [ApiController]
    public class AccountController : ControllerBase
    {
        [Route("/account/login")]
        [HttpPost]
        public async Task<IActionResult> LoginUser(LoginModel? ites)
        {
            try
            {
                await using var context = new DbController();

                var users = context.User.FirstOrDefault(e => e.Document == "1");

                // foreach (var item in users)
                // {
                //     Console.WriteLine(item);
                // }

                // if (controller.isInititiated)
                // {
                //     await controller.LoginUser(ites.Value.Email, ites.Value.Password);
                // }
                return Ok($"Request Body As String: {ites}");
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e);
                return Ok($"Request Body As String: {ites}");
            }
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
