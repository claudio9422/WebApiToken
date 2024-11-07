using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Custom;
using WebApi.Models;
using WebApi.Models.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Authorize]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly B2bUsuarioContext _b2bUsuarioContext;

        public ProductoController(B2bUsuarioContext b2bUsuarioContext)
        {

            _b2bUsuarioContext = b2bUsuarioContext;

        }

        [HttpGet]
        [Route("Lista")]
        public async Task<IActionResult> Lista()
        {
            var lista = await _b2bUsuarioContext.Pais.ToListAsync();
            return StatusCode(StatusCodes.Status200OK, new { isSuccess = true, value = lista });
        }

    }
}
