using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using woolworths.Dtos.AccountDto;
using woolworths.Interfaces;

namespace woolworths.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthService _authService;
        public AccountController(IAuthService authService, ITokenService tokenService)
        {
            _tokenService = tokenService;
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _authService.LoginAsync(loginDto);
            if (!result.Succeeded) return BadRequest("Login failed, please check your email and password!");

            var token = _tokenService.GenerateToken(loginDto.Email);
            return Ok(new UserDto
            {
                Email = loginDto.Email,
                Token = token
            });
        }


        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto registerDto) {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            var result = await _authService.RegisterAsync(registerDto);
            if(!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault().Description);
            return Ok();
        }
    }
}