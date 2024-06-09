using CRM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
              new Claim("Ematricule", Guid.NewGuid().ToString()), // Assuming Id is the primary key
           new Claim(JwtRegisteredClaimNames.Sub, user.Login),
           new Claim("IdtypeUser", authenticatedUser.IdtypeUser.ToString()) // Include IdtypeUser claim
       }),
                    Expires = DateTime.UtcNow.AddMinutes(60),
                    Issuer = issuer,
                    Audience = audience,
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var token = tokenHandler.CreateToken(tokenDescriptor);
                var jwtToken = tokenHandler.WriteToken(token);


                return Ok(new { token = jwtToken, idtypeuser = authenticatedUser.IdtypeUser });
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

            // Generate a random unique Ematricule
            string generatedEmatricule;
            bool isUnique = false;
            Random random = new Random();

            do
            {
                generatedEmatricule = GenerateRandomEmatricule();
                isUnique = !_dbContext.UtilisateurApplications.Any(u => u.Ematricule == generatedEmatricule);
            } while (!isUnique);

            // Retrieve the TypeUtilisateur based on the IdtypeUser provided in newUser
            var typeUser = _dbContext.TypeUtilisateurs.FirstOrDefault(t => t.IdtypeU == newUser.IdtypeUser);
            if (typeUser == null)
            {
                return BadRequest("Invalid type user provided");
            }

            // Create a new user
            var user = new UtilisateurApplication
            {
                Ematricule = generatedEmatricule,
                Login = newUser.Login,
                Motdepasse = newUser.Motdepasse, // You might want to hash the password here for security reasons
                IdtypeUser = typeUser.IdtypeU, // Set the foreign key property
              

            };

            _dbContext.UtilisateurApplications.Add(user);
            _dbContext.SaveChanges();

            return Ok("User registered successfully");
        }


        // Method to generate a random Ematricule
        private string GenerateRandomEmatricule()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
   
        [HttpGet("utilisateursapplication")]
        public async Task<ActionResult<IEnumerable<UtilisateurApplication>>> Getusers()
        {
            if (_dbContext.UtilisateurApplications == null)
            {
                return NotFound();
            }
            return await _dbContext.UtilisateurApplications.ToListAsync();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TypeUtilisateur>>> Getjobs()
        {
            if (_dbContext.TypeUtilisateurs == null)
            {
                return NotFound();
            }
            return await _dbContext.TypeUtilisateurs.ToListAsync();
        }



    }
}
