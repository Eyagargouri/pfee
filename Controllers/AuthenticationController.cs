using CRM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {

        private readonly IConfiguration _configuration;
        private readonly EdidynamiqueHbcContext _dbContext;

        public AuthenticationController(IConfiguration configuration, EdidynamiqueHbcContext dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UtilisateurApplication user)
        {
            if (user == null || string.IsNullOrEmpty(user.Login) || string.IsNullOrEmpty(user.Motdepasse))
            {
                return BadRequest("Invalid user request!!!");
            }
            var authenticatedUser = _dbContext.UtilisateurApplications
           .SingleOrDefault(u => u.Login == user.Login && u.Motdepasse == user.Motdepasse);
            if (authenticatedUser != null)
            {
                var issuer = _configuration["Jwt:Issuer"];
                var audience = _configuration["Jwt:Audience"];
                var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new[]
                    {
                        new Claim("Ematricule", Guid.NewGuid().ToString()),
                        new Claim(JwtRegisteredClaimNames.Sub, user.Login),

                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(5),
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var jwtToken = tokenHandler.WriteToken(token);
                return Ok(jwtToken);
            }

            return Unauthorized();
        }
        [HttpPost("register")]
        public IActionResult Register([FromBody] UtilisateurApplication newUser)
        {
            if (newUser == null || string.IsNullOrEmpty(newUser.Login) || string.IsNullOrEmpty(newUser.Motdepasse))
            {
                return BadRequest("Invalid user request!!!");
            }

            // Check if the user already exists
            var existingUser = _dbContext.UtilisateurApplications.FirstOrDefault(u => u.Login == newUser.Login);
            if (existingUser != null)
            {
                return Conflict("User already exists");
            }

            // Create a new user with a random Ematricule
            var user = new UtilisateurApplication
            {
                Ematricule = Guid.NewGuid().ToString(),

                Login = newUser.Login,
                Motdepasse = newUser.Motdepasse // You might want to hash the password here for security reasons
            };
            
            _dbContext.UtilisateurApplications.Add(user);
            _dbContext.SaveChanges();

            return Ok("User registered successfully");
        }





    }
}
