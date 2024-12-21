using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using woolworths.Models;

namespace woolworths.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string email);
    }
}