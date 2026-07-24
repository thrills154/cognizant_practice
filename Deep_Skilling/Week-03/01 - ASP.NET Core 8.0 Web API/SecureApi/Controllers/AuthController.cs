// Deep Skilling - Cognizant Practice
// Author: thrills154
// Module: Controllers

using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SecureApi.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SecureApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private static readonly List<User> _registeredUsers = new()
    {
        new User { Username = "admin", Password = "@dminPass2024", Role = "Admin" },
        new User { Username = "user", Password = "us3rPass2024", Role = "User" }
    };

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        var user = _registeredUsers.FirstOrDefault(u => u.Username == request.Username && u.Password == request.Password);
        if (user == null) return Unauthorized("Invalid credentials");
        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MyCustomJWTSecretKeyForAuthentication2025!"));
        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
        var claims = new[] { new Claim(ClaimTypes.Name, user.Username), new Claim(ClaimTypes.Role, user.Role) };
        var token = new JwtSecurityToken(issuer: "SecureApi", audience: "SecureApi", claims: claims, expires: DateTime.Now.AddHours(1), signingCredentials: creds);
        return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
    }
}
