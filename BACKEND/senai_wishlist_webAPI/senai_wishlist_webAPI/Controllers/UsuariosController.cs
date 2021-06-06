using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_wishlist_webAPI.Domains;
using senai_wishlist_webAPI.Interfaces;
using senai_wishlist_webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace senai_wishlist_webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // COM ID JWT INCLUÍDO:

        //private IUsuarioRepository _usuarioRepository;

        //public UsuariosController()
        //{
        //    _usuarioRepository = new UsuarioRepository();
        //}

        //[Authorize]
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

        //        return Ok(_usuarioRepository.ListarPerfil(idUsuario));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        //[Authorize]
        //[HttpGet("{id}")]
        //public IActionResult GetById(int id)
        //{
        //    try
        //    {
        //        Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(id);

        //        if (usuarioBuscado == null)
        //        {
        //            return NotFound("Nenhum usuário encontrado!");
        //        }

        //        return Ok(usuarioBuscado);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

    }
}
