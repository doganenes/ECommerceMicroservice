using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Multishop.IdentityServer.Dtos;
using Multishop.IdentityServer.Models;
using System.Threading.Tasks;
using static IdentityServer4.IdentityServerConstants;

namespace Multishop.IdentityServer.Controllers
{
    [Authorize(LocalApi.PolicyName)]
    [Route("api/[controller]")]
    [ApiController]
    public class RegistersController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> UserRegister(UserRegisterDto dto)
        { 
            var values = new ApplicationUser()
            {
                UserName = dto.Username,
                Email = dto.Email,
                Name = dto.Name,
                Surname = dto.Surname,
            };

            var result = await _userManager.CreateAsync(values, dto.Password);
            if (result.Succeeded) {
                return Ok("User registered successfully!");
            }
            else
            {
                return Ok("An error occured while user registration!");
            }
        }
    }
}
