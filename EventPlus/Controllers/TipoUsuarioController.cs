using EventPlus.Domains;
using EventPlus.Interfaces;
using EventPlus.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventPlus.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuarioController : ControllerBase
    {
        private readonly ITipoUsuarioRepository _tiposUsuarioRepository;
        public TipoUsuarioController (ITipoUsuarioRepository tipoUsuarioRepository)
        {
            _tiposUsuarioRepository = tipoUsuarioRepository;
        }
        //cadastrar
        [HttpPost]
        public IActionResult Post(TipoUsuario tipoUsuario)
        {
            try
            {
                _tiposUsuarioRepository.Cadastrar(tipoUsuario);

                return Created();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        //deletar
        [HttpDelete("{id}")]
        public IActionResult DeleteById(Guid id)
        {
            try
            {
                _tiposUsuarioRepository.Deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }
        //listar
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                List<TipoUsuario> listaDeUsuario = _tiposUsuarioRepository.Listar();
                return Ok(listaDeUsuario);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }

        //BuscarPorId 
        [HttpGet("BuscarPorId/{id}")]
        public IActionResult GetById(Guid id, TipoUsuario tiposUsuarios)
        {
            try
            {
                TipoUsuario tiposUsuariosBuscado = _tiposUsuarioRepository.BuscarPorId(id);
                return Ok(tiposUsuariosBuscado);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, TipoUsuario tiposUsuarios)
        {
            try
            {
                _tiposUsuarioRepository.Atualizar(id, tiposUsuarios);

                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

    }
}

