using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Oceantecsa.Infrastructure.DTOS;
using Oceantecsa.Infrastructure.IdentityServices;
using Oceantecsa.Shared.BaseController;
using Oceantecsa.Shared.Helpers.RequestAndResponse;

namespace OceantecsaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : OceanTecsaController
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }


        [HttpPost("Login")]
        [ProducesResponseType(typeof(GenericResponse<string>), 00)]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {
            var result = await _authService.Login(loginDto);
            if (!result.Item1)
                return Unauthorized("IncorrectUserNameOrPassword");
            return Success(result.Item2);
        }
    }
}
