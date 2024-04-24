using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace web_intranet_net8.Identity;

public class FakeAuthenticationService
{
    public Task<ClaimsPrincipal?> Login(string username, string password)
    {
        ClaimsPrincipal? result = null;

        if (username == "admin" && password == "admin")
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Email, $"{username}@test.cl")
            };
            result = new ClaimsPrincipal(new ClaimsIdentity(claims, "fake"));
        }

        return Task.FromResult(result);
        
    }
}
