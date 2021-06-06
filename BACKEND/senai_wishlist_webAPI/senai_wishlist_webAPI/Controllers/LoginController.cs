using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai_wishlist_webAPI.Domains;
using senai_wishlist_webAPI.Interfaces;
using senai_wishlist_webAPI.Repositories;
using senai_wishlist_webAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai_wishlist_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // COM ID JWT INCLUÍDO:

        //private IUsuarioRepository _loginRepository;

        //public LoginController()
        //{
        //    _loginRepository = new UsuarioRepository();
        //}

        //[HttpPost]
        //public IActionResult Login(LoginViewModel login)
        //{
        //    try
        //    {
        //        Usuario usuarioBuscado = _loginRepository.Login(login.email, login.senha);

        //        if (usuarioBuscado == null)
        //        {
        //            return NotFound("E-mail ou senha inválidos!");
        //        }

        //        var claims = new[]
        //        {
        //            new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),

        //            new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.IdUsuario.ToString()),

        //            new Claim(ClaimTypes.Role, usuarioBuscado.IdUsuario.ToString())
        //            };

        //        var secretKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("wish-chave-autenticacao"));

        //        var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

        //        var dadosToken = new JwtSecurityToken(
        //            issuer: "wish.webAPI",
        //            audience: "wish.webAPI",
        //            claims: claims,
        //            expires: DateTime.Now.AddMinutes(30),
        //            signingCredentials: credentials
        //            );

        //        return Ok(new
        //        {
        //            token = new JwtSecurityTokenHandler().WriteToken(dadosToken)
        //        });

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}
    }
}
