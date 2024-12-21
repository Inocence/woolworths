using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using woolworths.Models;
using Microsoft.AspNetCore.Identity;
using woolworths.Dtos.AccountDto;

namespace woolworths.Interfaces
{
    public interface IAuthService
    {
        Task<SignInResult> LoginAsync(LoginDto loginDto);
        Task<IdentityResult> RegisterAsync(RegisterDto registerDto);
    }
}