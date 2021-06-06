using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_wishlist_webAPI.Domains;
using senai_wishlist_webAPI.Interfaces;
using senai_wishlist_webAPI.Repositories;
using senai_wishlist_webAPI.ViewModel;
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
    public class DesejosController : ControllerBase
    {
        private IDesejoRepository _desejoRepository;

        public DesejosController()
        {
            _desejoRepository = new DesejoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_desejoRepository.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Desejo desejoBuscada = _desejoRepository.BuscarPorId(id);

                if (desejoBuscada == null)
                {
                    return NotFound("Nenhum desejo encontrado!");
                }

                return Ok(desejoBuscada);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(Desejo novoDesejo)
        {
            try
            {
                //Faz a chamada para o método
                _desejoRepository.Cadastrar(novoDesejo);

                //Retorna um status code
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, DesejoViewModel desejoAtualizado)
        {
            try
            {
                Desejo desejoBuscado = _desejoRepository.BuscarPorId(id);

                if (desejoBuscado != null)
                {
                    desejoBuscado = new Desejo
                    {
                        Descricao = desejoAtualizado.descricao
                    };

                    _desejoRepository.Atualizar(id, desejoBuscado);

                    return StatusCode(204);
                }
                return BadRequest("Nenhum desejo encontrado!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _desejoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }


        //[Authorize]
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    try
        //    {
        //        return Ok(_desejoRepository.ListarDesejos());
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
        //        Desejo desejoBuscada = _desejoRepository.BuscarPorId(id);

        //        if (desejoBuscada == null)
        //        {
        //            return NotFound("Nenhum desejo encontrado!");
        //        }

        //        return Ok(desejoBuscada);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        //[Authorize]
        //[HttpPost]
        //public IActionResult Post(Desejo novoDesejo)
        //{
        //    try
        //    {
        //        Desejo desejo = new Desejo()
        //        {
        //            IdDesejo = novoDesejo.IdDesejo,

        //            IdUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value),

        //            Descricao = novoDesejo.Descricao,

        //            DataCriacao = DateTime.Now,

        //            Favorito = false
        //        };

        //        //Faz a chamada para o método
        //        _desejoRepository.Cadastrar(desejo);

        //        //Retorna um status code
        //        return StatusCode(201);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        //[Authorize]
        //[HttpPatch("{id}")]
        //public IActionResult Patch(int id, DesejoViewModel desejoAtualizado)
        //{
        //    try
        //    {
        //        int idUsuario = Convert.ToInt32(HttpContext.User.Claims.First(c => c.Type == JwtRegisteredClaimNames.Jti).Value);

        //        Desejo desejoBuscado = _desejoRepository.BuscarPorId(id);

        //        if (desejoBuscado != null)
        //        {
        //            desejoBuscado = new Desejo
        //            {
        //                Descricao = desejoAtualizado.descricao
        //            };

        //            _desejoRepository.Atualizar(idUsuario, desejoBuscado);

        //            return StatusCode(204);
        //        }
        //        return BadRequest("Nenhum desejo encontrado!");
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

        //[Authorize]
        //[HttpDelete("{id}")]
        //public IActionResult Delete(int id)
        //{
        //    try
        //    {
        //        _desejoRepository.Deletar(id);

        //        return StatusCode(204);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex);
        //    }
        //}

    }
}
