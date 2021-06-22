using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GSystemsApi.Data;
using GSystemsApi.Models;
using Microsoft.AspNetCore.Authorization;
using System.Web.Http;
using Microsoft.IdentityModel.Protocols;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using System.Configuration;
using GSystemsApi.Auth;

namespace GSystemsApi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class EmpleadoLoginController : ControllerBase
    {
        private readonly GSystemsApiContext _context;
        private readonly JwtAuthenticationService _authService;

        public EmpleadoLoginController(GSystemsApiContext context, JwtAuthenticationService authService)
        {
            _context = context;
            _authService = authService;
        }

        [System.Web.Http.AllowAnonymous]
        [Microsoft.AspNetCore.Mvc.HttpPost("authenticate")]
        public IActionResult Authenticate([System.Web.Http.FromBody] EmpleadoLogin empleado)
        {
            var token = _authService.Authenticate(empleado.Mail, empleado.Password);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
