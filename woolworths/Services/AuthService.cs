using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using woolworths.Constants;
using woolworths.Data;
using woolworths.Dtos.AccountDto;
using woolworths.Interfaces;
using woolworths.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;

namespace api.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public AuthService(
            ApplicationDbContext context,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public async Task<SignInResult> LoginAsync(LoginDto loginDto)
        {
            var appUser = await _userManager.FindByEmailAsync(loginDto.Email);
            var result = await _signInManager.PasswordSignInAsync(appUser, loginDto.Password, false, false);
            return result;
        }

        public async Task<IdentityResult> RegisterAsync(RegisterDto registerDto)
        {
            var appUser = new AppUser { Email = registerDto.Email, UserName = registerDto.Email };
            var result = await _userManager.CreateAsync(appUser, registerDto.Password);
            if (!result.Succeeded) return result;

            var resultRole = await _userManager.AddToRoleAsync(appUser, AppUserRoles.Customer);
            return resultRole;
        }
    }
}