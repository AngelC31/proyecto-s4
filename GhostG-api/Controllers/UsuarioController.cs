using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GhostG_api.Models;
using Microsoft.EntityFrameworkCore;

namespace GhostG_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly GhostGymContext _dbcontext;

        public UsuarioController(GhostGymContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            List<Usuario> lista = await _dbcontext.Usuarios.OrderByDescending(c => c.IdUsuario).ToListAsync();

            return StatusCode(StatusCodes.Status200OK, lista);
        }
        [HttpPost]
        [Route("Guardar")]
        public async Task<IActionResult> Guardar([FromBody] Usuario request)
        {
            await _dbcontext.Usuarios.AddAsync(request);
            await _dbcontext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "ok");
        }

        [HttpPut]
        [Route("Editar")]
        public async Task<IActionResult> Editar([FromBody] Usuario request)
        {
            _dbcontext.Usuarios.Update(request);
            await _dbcontext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "ok");
        }

        [HttpDelete]
        [Route("Eliminar/id:int")]
        public async Task<IActionResult> Eliminar(int id)
        {
            Usuario usuario = _dbcontext.Usuarios.Find(id);

            _dbcontext.Usuarios.Remove(usuario);
            await _dbcontext.SaveChangesAsync();

            return StatusCode(StatusCodes.Status200OK, "ok");

        }
    }
}
