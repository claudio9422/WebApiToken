using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Custom;
using WebApi.Models;
using WebApi.Models.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [AllowAnonymous]
    [ApiController]
    public class AccesoController : ControllerBase
    {
        private readonly B2bUsuarioContext _b2bUsuarioContext;
        private readonly Utilidades _utilidades;
        public AccesoController(B2bUsuarioContext b2bUsuarioContext, Utilidades utilidades)
        {
            _b2bUsuarioContext = b2bUsuarioContext;
            _utilidades = utilidades;

        }

        [HttpPost]
        [Route("Registrarse")]
        public async Task<IActionResult> Registrarse(UsuarioDTO objeto)
        {
            var modeloUsuario = new Usuario
            {
                Nombre = objeto.Nombre,
                Email = objeto.Correo,
                Password = _utilidades.encriptarSHA256(objeto.Clave)
            };

            await _b2bUsuarioContext.Usuarios.AddAsync(modeloUsuario);
            await _b2bUsuarioContext.SaveChangesAsync();

            if (modeloUsuario.IdUsuario != 0)
            {
                return StatusCode(StatusCodes.Status200OK, new { isSuccess = true });
            }
            else
            {
                return StatusCode(StatusCodes.Status200OK, new { isSuccess = false });
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginDTO objeto)
        {
            var usuarioEncontrado = await _b2bUsuarioContext.Usuarios
                .Where(u =>
                u.Login == objeto.Correo &&
                u.Email == objeto.Clave //_utilidades.encriptarSHA256(objeto.Clave)
            ).FirstOrDefaultAsync();

            if(usuarioEncontrado == null)
                return StatusCode(StatusCodes.Status200OK,new {isSuccess = false, token = "" });
            else
                return StatusCode(StatusCodes.Status200OK, new { isSuccess = true, token = _utilidades.generarJWT(usuarioEncontrado) });
        }

    }
}
