using GSystemsApi.Data;
using GSystemsApi.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GSystemsApi.Auth
{
    public class JwtAuthenticationService
    {
        private readonly string _key;

        private readonly GSystemsApiContext _context;
        public JwtAuthenticationService(string key, GSystemsApiContext context)
        {
            _key = key;
            _context = context;
        }

        public string Authenticate(string mail, string password)
        {
            //Obtenemos el usuario por el Mail.
            EmpleadoLogin empleadoLogin = _context.EmpleadoLogin.Where(x => x.Mail.Equals(mail) && x.Password.Equals(password)).FirstOrDefault();
            if (empleadoLogin == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, mail)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
